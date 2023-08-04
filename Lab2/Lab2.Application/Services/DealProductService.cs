using AutoMapper;
using Lab2.Application.DTOs.DealProduct;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Domain;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Exceptions;
using Lab2.Domain.Repositories;

namespace Lab2.Application.Services;

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
        if (!await _productRepository.IsProductExistAsync(addDealProductDto.ProductId))
            throw new EntityNotFoundException($"Product with id {addDealProductDto.ProductId} not found");

        // 2. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId)
            ?? throw new EntityNotFoundException($"Deal with id {dealId} not found");

        // 3. Add deal's product to deal
        var dealProduct = _mapper.Map<DealProduct>(addDealProductDto);
        dealProduct.DealId = dealId;
        _dealProductRepository.Add(dealProduct);

        // 4. Update deal's actual revenue
        deal.ActualRevenue += dealProduct.PricePerUnit * dealProduct.Quantity;

        // 5. Save changes
        await _unitOfWork.SaveChangesAsync();
        // Refetch from database to load related data
        return _mapper.Map<GetDealProductDto>(await GetDealProductByIdAsync(dealProduct.Id));
    }

    public async Task DeleteDealProductAsync(int dealProductId, int dealId)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(dealProductId)
            ?? throw new EntityNotFoundException($"Deal's product with id {dealProductId} not found");

        var deal = await _dealRepository.GetByIdAsync(dealProduct.DealId)
            ?? throw new EntityNotFoundException($"Deal with id {dealProduct.DealId} not found");
        
        // 2. Check if dealId provided from client is valid
        if (dealId != deal.Id)
            throw new InvalidUpdateException($"Deal's product with id {dealProductId} not found in deal with id {dealId}");
        
        // 3. If deal is ended (won or lost), throw exception
        if (deal.Status is (int)DealStatus.Won or (int)DealStatus.Lost)
            throw new InvalidUpdateException("Deal is ended");

        // 4. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;

        // 5. Delete dealProduct
        _dealProductRepository.Delete(dealProduct);
        await _unitOfWork.SaveChangesAsync();
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
                                                                      dealId: dealId);

        var result = _mapper.Map<List<GetDealProductDto>>(dealProducts);

        return new PagedResult<GetDealProductDto>(result, totalCount, dpqp.PageIndex, dpqp.PageSize);
    }

    public async Task<GetDealProductDto> UpdateDealProductAsync(int dealProductId, int dealId, UpdateDealProductDto dealProductDto)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(dealProductId)
            ?? throw new EntityNotFoundException($"Deal's product with id {dealProductId} not found");
        
        // 2. Check if dealId provided from client is valid
        if (dealId != dealProduct.DealId)
            throw new InvalidUpdateException($"Deal's product with id {dealProductId} not found in deal with id {dealId}");

        // 3. If deal is ended (won or lost), throw exception
        var deal = await _dealRepository.GetByIdAsync(dealProduct.DealId);
        if (deal!.Status is (int)DealStatus.Won or (int)DealStatus.Lost)
            throw new InvalidUpdateException("Deal is ended");

        // 4. If product is changed, check if new product exists
        if (dealProduct.ProductId != dealProductDto.ProductId && !await _productRepository.IsProductExistAsync(dealProductDto.ProductId))
                throw new EntityNotFoundException($"Product with id {dealProductDto.ProductId} not found");

        // 5. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;
        deal.ActualRevenue += dealProductDto.PricePerUnit * dealProductDto.Quantity;

        // 6. Update dealProduct
        _mapper.Map(dealProductDto, dealProduct);
        await _unitOfWork.SaveChangesAsync();
        // Return dto with related data from Product
        return _mapper.Map<GetDealProductDto>(await GetDealProductByIdAsync(dealProduct.Id));
    }
}
