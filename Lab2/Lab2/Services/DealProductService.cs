using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.DealProduct;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class DealProductService : IDealProductService
{
    private readonly IDealRepository _dealRepository;
    private readonly IDealProductRepository _dealProductRepository;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DealProductService(IDealRepository dealRepository,
                       IDealProductRepository dealProductRepository,
                       IProductRepository productRepository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork)
    {
        _dealRepository = dealRepository;
        _dealProductRepository = dealProductRepository;
        _productRepository = productRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<GetDealProductDto> AddProductToDealAsync(int dealId, AddDealProductDto addDealProductDto)
    {
        // 1. Check if product exists
        if (!await _productRepository.IsExistAsync(p => p.Id == addDealProductDto.ProductId))
            throw new EntityNotFoundException($"Product with id {addDealProductDto.ProductId} not found");

        // 2. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId);
        if (deal == null)
            throw new EntityNotFoundException($"Deal with id {dealId} not found");

        // 3. Add deal's product to deal
        var dealProduct = _mapper.Map<DealProduct>(addDealProductDto);
        dealProduct.DealId = dealId;
        _dealProductRepository.Add(dealProduct);

        // 4. Update deal's actual revenue
        deal.ActualRevenue += dealProduct.PricePerUnit * dealProduct.Quantity;

        // 5. Save changes
        await _unitOfWork.CommitAsync();
        // Refetch from database to load related data
        return _mapper.Map<GetDealProductDto>(await GetDealProductByIdAsync(dealProduct.Id));
    }

    public async Task DeleteDealProductAsync(int dealProductId)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(dealProductId);
        if (dealProduct == null)
            throw new EntityNotFoundException($"Deal's product with id {dealProductId} not found");

        var deal = await _dealRepository.GetByIdAsync(dealProduct.DealId);

        // 2. If deal is ended (won or lost), throw exception
        if (deal!.Status is (int)DealStatus.Won or (int)DealStatus.Lost)
            throw new InvalidUpdateException("Deal is ended");

        // 3. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;

        // 4. Delete dealProduct
        _dealProductRepository.Delete(dealProduct);
        await _unitOfWork.CommitAsync();
    }

    public async Task<GetDealProductDto?> GetDealProductByIdAsync(int dealProductId)
    {
        return _mapper.Map<GetDealProductDto>(await _dealProductRepository.GetByIdAsync(dealProductId));
    }

    public async Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp)
    {
        var (dealProducts, totalCount) = await _dealProductRepository.GetDealProductPagedListAsync(
                                                                      search: dpqp.Search,
                                                                      orderBy: dpqp.OrderBy,
                                                                      skip: (dpqp.PageIndex - 1) * dpqp.PageSize,
                                                                      take: dpqp.PageSize,
                                                                      isDescending: dpqp.IsDescending,
                                                                      condition: dp => dp.DealId == dealId);

        var result = _mapper.Map<List<GetDealProductDto>>(dealProducts);

        return new PagedResult<GetDealProductDto>(result, totalCount, dpqp.PageIndex, dpqp.PageSize);
    }

    public async Task<GetDealProductDto> UpdateDealProductAsync(int dealProductId, UpdateDealProductDto updateDealProductDto)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(dealProductId);
        if (dealProduct == null)
            throw new EntityNotFoundException($"Deal's product with id {dealProductId} not found");

        var deal = await _dealRepository.GetByIdAsync(dealProduct.DealId);

        // 2. If deal is ended (won or lost), throw exception
        if (deal!.Status is (int)DealStatus.Won or (int)DealStatus.Lost)
            throw new InvalidUpdateException("Deal is ended");

        // 3. If product is changed, check if new product exists
        if (dealProduct.ProductId != updateDealProductDto.ProductId)
        {
            if (!await _productRepository.IsExistAsync(p => p.Id == updateDealProductDto.ProductId))
                throw new EntityNotFoundException($"Product with id {updateDealProductDto.ProductId} not found");
        }

        // 4. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;
        deal.ActualRevenue += updateDealProductDto.PricePerUnit * updateDealProductDto.Quantity;

        // 5. Update dealProduct
        _mapper.Map(updateDealProductDto, dealProduct);
        await _unitOfWork.CommitAsync();
        // Return dto with related data from Product
        return _mapper.Map<GetDealProductDto>(await GetDealProductByIdAsync(dealProduct.Id));
    }
}
