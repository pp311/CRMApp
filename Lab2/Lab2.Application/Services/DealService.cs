using AutoMapper;
using Lab2.Application.DTOs.Deal;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Domain;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Exceptions;
using Lab2.Domain.Repositories;

namespace Lab2.Application.Services;

public class DealService : IDealService
{
    private readonly IDealRepository _dealRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public DealService(IDealRepository dealRepository,
                       IAccountRepository accountRepository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork)
    {
        _dealRepository = dealRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task DeleteAsync(int id)
    {
        // Check if deal exists
        var deal = await _dealRepository.GetByIdAsync(id)
            ?? throw new EntityNotFoundException($"Deal with id {id} not found");

        // Subtract account's total sales with deal's actual revenue
        var account = await _accountRepository.GetByIdAsync(deal.Lead!.AccountId);
        account!.TotalSales -= deal.ActualRevenue;

        _dealRepository.Delete(deal);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<GetDealDetailDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<GetDealDetailDto>(await _dealRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<GetDealDetailDto>> GetListAsync(DealQueryParameters dqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(search: dqp.Search,
                                                                             status: dqp.Status,
                                                                             orderBy: dqp.OrderBy,
                                                                             skip: (dqp.PageIndex - 1) * dqp.PageSize,
                                                                             take: dqp.PageSize,
                                                                             isDescending: dqp.IsDescending);
        var result = _mapper.Map<List<GetDealDetailDto>>(deals);

        return new PagedResult<GetDealDetailDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }
    
    public async Task<PagedResult<GetDealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters dqp)
    {
        if (!await _accountRepository.IsAccountExistAsync(accountId))
            throw new EntityNotFoundException($"Account with id {accountId} not found");
        
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(
                                                                             accountId: accountId,
                                                                             search: dqp.Search,
                                                                             status: dqp.Status,
                                                                             orderBy: dqp.OrderBy,
                                                                             skip: (dqp.PageIndex - 1) * dqp.PageSize,
                                                                             take: dqp.PageSize,
                                                                             isDescending: dqp.IsDescending);
        var result = _mapper.Map<List<GetDealDto>>(deals);
        return new PagedResult<GetDealDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }

    public async Task<GetDealDetailDto> UpdateAsync(int dealId, UpdateDealDto dealDto)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId)
            ?? throw new EntityNotFoundException($"Deal with id {dealId} not found");

        // 2. If deal is ended (won or lost), cannot change deal title
        if (deal.Status != (int)DealStatus.Open && dealDto.Title != deal.Title)
            throw new InvalidUpdateException("Cannot change title when deal is ended");

        // 3. Update deal
        _mapper.Map(dealDto, deal);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetDealDetailDto>(deal);
    }

    public async Task<DealStatisticsDto> GetDealStatisticsAsync()
    {
        var statistics = await _dealRepository.GetDealStatisticsAsync();
        statistics.AverageRevenue = Math.Round(statistics.AverageRevenue, 2);
        statistics.TotalRevenue = Math.Round(statistics.TotalRevenue, 2);
        return _mapper.Map<DealStatisticsDto>(statistics);
    }

    public async Task<GetDealDetailDto> MarkDealAsWonAsync(int dealId)
    {
        var deal = await ValidateClosingDeal(dealId);

        // Update deal
        deal.Status = (int)DealStatus.Won;

        // Recalculate account's total sales (sum of all deal's actual revenues)
        var account = await _accountRepository.GetByIdAsync(deal.Lead!.AccountId);
        account!.TotalSales += deal.ActualRevenue;

        // Save changes
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetDealDetailDto>(deal);
    }

    public async Task<GetDealDetailDto> MarkDealAsLostAsync(int dealId)
    {
        var deal = await ValidateClosingDeal(dealId);
        
        // Update deal
        deal.Status = (int)DealStatus.Lost;
        
        // Recalculate account's total sales (sum of all deal's actual revenues)
        var account = await _accountRepository.GetByIdAsync(deal.Lead!.AccountId);
        account!.TotalSales += deal.ActualRevenue;

        // Save changes
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetDealDetailDto>(deal);
    }

    private async Task<Deal> ValidateClosingDeal(int dealId)
    {
        // 1. Get deal from database
        var deal = await _dealRepository.GetByIdAsync(dealId)
            ?? throw new EntityNotFoundException($"Deal with id {dealId} not found");

        // 2. If deal is already ended (won or lost), throw exception
        if (deal.Status is not (int)DealStatus.Open)
            throw new InvalidUpdateException("Deal is already ended");

        return deal;
    }
}
