using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IDealService
{
    Task<GetDealDetailDto?> GetByIdAsync(int id);
    Task<PagedResult<GetDealDetailDto>> GetListAsync(DealQueryParameters dqp);
    Task<PagedResult<GetDealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters dealQueryParameters);
    Task<GetDealDetailDto> UpdateAsync(int dealId, UpdateDealDto dealDto);
    Task DeleteAsync(int id);
    Task<GetDealDetailDto> MarkDealAsWonAsync(int dealId);
    Task<GetDealDetailDto> MarkDealAsLostAsync(int dealId);
    Task<DealStatisticsDto> GetDealStatisticsAsync();
}
