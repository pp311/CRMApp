using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class DealService : IDealService
{
    private readonly IDealRepository _dealRepository;
    private readonly IDealProductRepository _dealProductRepository;
    private readonly IProductRepository _productRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DealService(IDealRepository dealRepository,
                       IDealProductRepository dealProductRepository,
                       IProductRepository productRepository,
                          IAccountRepository accountRepository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork)
    {
        _dealRepository = dealRepository;
        _dealProductRepository = dealProductRepository;
        _productRepository = productRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task DeleteAsync(int id)
    {
        // Check if deal exists
        if (!await _dealRepository.IsExistAsync(d => d.Id == id))
            throw new EntityNotFoundException($"Deal with id {id} not found");
        
        _dealRepository.Delete(new Deal { Id = id });
        await _unitOfWork.CommitAsync();
    }

    public async Task<GetDealDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<GetDealDto>(await _dealRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<DealDto>> GetListAsync(DealQueryParameters dqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(search: dqp.Search,
                                                                             status: dqp.Status,
                                                                             orderBy: dqp.OrderBy,
                                                                             skip: (dqp.PageIndex - 1) * dqp.PageSize,
                                                                             take: dqp.PageSize,
                                                                             isDescending: dqp.IsDescending);
        var result = _mapper.Map<List<DealDto>>(deals);

        return new PagedResult<DealDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }

    public async Task<DealDto> UpdateAsync(DealDto dealDto)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealDto.Id);
        if (deal == null)
            throw new EntityNotFoundException($"Deal with id {dealDto.Id} not found");
        
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status is (int)DealStatus.Won or (int)DealStatus.Lost)
            throw new InvalidUpdateException("Deal is ended");
        
        // 3. Update deal
        _mapper.Map(dealDto, deal);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<DealDto>(deal);
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

    public async Task<GetDealProductDto?> GetDealProductByIdAsync(int dealProductId)
    {
        return _mapper.Map<GetDealProductDto>(await _dealProductRepository.GetByIdAsync(dealProductId));
    }

    public async Task<GetDealProductDto> AddProductToDealAsync(AddDealProductDto addDealProductDto)
    {
        // 1. Check if product exists
        if (!await _productRepository.IsExistAsync(p => p.Id == addDealProductDto.ProductId))
            throw new EntityNotFoundException($"Product with id {addDealProductDto.ProductId} not found");
        
        // 2. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(addDealProductDto.DealId);
        if (deal == null)
            throw new EntityNotFoundException($"Deal with id {addDealProductDto.DealId} not found");
        
        // 3. Add deal's product to deal
        var dealProduct = _mapper.Map<DealProduct>(addDealProductDto);
        _dealProductRepository.Add(dealProduct);
        
        // 4. Update deal's actual revenue
        deal.ActualRevenue += dealProduct.PricePerUnit * dealProduct.Quantity;
        
        // 5. Save changes
        await _unitOfWork.CommitAsync();
        
        return _mapper.Map<GetDealProductDto>(dealProduct);

    }

    public async Task<GetDealProductDto> UpdateDealProductAsync(UpdateDealProductDto updateDealProductDto)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(updateDealProductDto.Id);
        if (dealProduct == null)
            throw new EntityNotFoundException($"Deal's product with id {updateDealProductDto.Id} not found");
        
        var deal = await _dealRepository.GetByIdAsync(updateDealProductDto.DealId);
        
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
        return _mapper.Map<GetDealProductDto>(dealProduct);
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

    public async Task<DealStatisticsDto> GetDealStatisticsAsync()
    {
        return await _dealRepository.GetDealStatisticsAsync();
    }

    public async Task<GetDealDto> MarkDealAsWonAsync(int dealId)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId);
        if (deal == null)
            throw new EntityNotFoundException($"Deal with id {dealId} not found");
        
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status is not (int)DealStatus.Open)
            throw new InvalidUpdateException("Deal is ended");
        
        // 3. Update deal
        deal.Status = (int)DealStatus.Won;
        
        // 4. Recalculate account's total sales (sum of all deal's actual revenues)
        var account = await _accountRepository.GetByIdAsync(deal.Lead!.AccountId);
        account!.TotalSales += deal.ActualRevenue;
        
        // 5. Save changes
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetDealDto>(deal);
    }

    public async Task<GetDealDto> MarkDealAsLostAsync(int dealId)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId);
        if (deal == null)
            throw new EntityNotFoundException($"Deal with id {dealId} not found");
        
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status is not (int)DealStatus.Open)
            throw new InvalidUpdateException("Deal is ended");
        
        // 3. Update deal
        deal.Status = (int)DealStatus.Lost;
        
        // 4. Save changes
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetDealDto>(deal);
        
    }
}
