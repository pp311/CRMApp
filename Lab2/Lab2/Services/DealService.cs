using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Enums;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class DealService : IDealService
{
    private readonly IDealRepository _dealRepository;
    private readonly IDealProductRepository _dealProductRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DealService(IDealRepository dealRepository,
                       IDealProductRepository dealProductRepository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork)
    {
        _dealRepository = dealRepository;
        _dealProductRepository = dealProductRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _dealRepository.Delete(new Entities.Deal { Id = id });
        return await _unitOfWork.CommitAsync() > 0;
    }

    public async Task<GetDealDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<GetDealDto>(await _dealRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<DealDto>> GetListAsync(DealQueryParameters dqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(dqp);
        var result = _mapper.Map<List<DealDto>>(deals);

        return new PagedResult<DealDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }

    public async Task<DealDto> UpdateAsync(DealDto dealDto)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealDto.Id);
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status == (int)DealStatus.Won || deal.Status == (int)DealStatus.Lost)
        {
            throw new InvalidUpdateException("Deal is ended");
        }
        // 3. Update deal
        _mapper.Map(dealDto, deal);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<DealDto>(deal);
    }

    public async Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp)
    {
        var (dealProducts, dealProductCount) = await _dealProductRepository.GetDealProductPagedListAsync(dpqp, dp => dp.DealId == dealId);
        var result = _mapper.Map<List<GetDealProductDto>>(dealProducts);

        return new PagedResult<GetDealProductDto>(result, dealProductCount, dpqp.PageIndex, dpqp.PageSize);
    }

    public async Task<GetDealProductDto?> GetDealProductByIdAsync(int dealId, int dealProductId)
    {
        return _mapper.Map<GetDealProductDto>(await _dealProductRepository.GetByIdAsync(dealProductId, dealId));
    }

    public async Task<GetDealProductDto> AddProductToDealAsync(int dealId, AddDealProductDto addDealProductDto)
    {
        // 1. Map dto to entity
        var dealProduct = _mapper.Map<Entities.DealProduct>(addDealProductDto);
        // 2. Set dealId
        dealProduct.DealId = dealId;
        // 3. Add dealProduct to database
        _dealProductRepository.Add(dealProduct);
        // 4. Recalculate deal value
        var deal = await _dealRepository.GetByIdAsync(dealId);
        deal.ActualRevenue += dealProduct.PricePerUnit * dealProduct.Quantity;
        await _unitOfWork.CommitAsync();
        // 5. Return dto
        return _mapper.Map<GetDealProductDto>(dealProduct);
    }

    public async Task<GetDealProductDto> UpdateDealProductAsync(UpdateDealProductDto updateDealProductDto)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(updateDealProductDto.Id, updateDealProductDto.DealId);
        var deal = await _dealRepository.GetByIdAsync(updateDealProductDto.DealId);
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status == (int)DealStatus.Won || deal.Status == (int)DealStatus.Lost)
        {
            throw new InvalidUpdateException("Deal is ended");
        }
        // 3. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;
        deal.ActualRevenue += updateDealProductDto.PricePerUnit * updateDealProductDto.Quantity;
        // 4. Update dealProduct
        _mapper.Map(updateDealProductDto, dealProduct);
        await _unitOfWork.CommitAsync();
        // 5. Return dto
        return _mapper.Map<GetDealProductDto>(dealProduct);
    }

    public async Task<bool> DeleteDealProductAsync(int dealId, int dealProductId)
    {
        // 1. Get deal and dealProduct from database
        var dealProduct = await _dealProductRepository.GetByIdAsync(dealProductId, dealId);
        var deal = await _dealRepository.GetByIdAsync(dealId);
        // 2. If deal is ended (won or lost), throw exception
        if (deal.Status == (int)DealStatus.Won || deal.Status == (int)DealStatus.Lost)
        {
            throw new InvalidUpdateException("Deal is ended");
        }
        // 3. Recalculate deal value
        deal.ActualRevenue -= dealProduct.PricePerUnit * dealProduct.Quantity;
        // 4. Delete dealProduct
        _dealProductRepository.Delete(dealProduct);
        return await _unitOfWork.CommitAsync() > 0;
    }

    public async Task<DealStatisticsDto> GetDealStatisticsAsync()
    {
        return await _dealRepository.GetDealStatisticsAsync();
    }
}
