using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IDealService
{
    Task<GetDealDto?> GetByIdAsync(int id);
    Task<PagedResult<DealDto>> GetListAsync(DealQueryParameters dqp);
    // Task<DealDto> CreateAsync(DealDto deal);
    Task<DealDto> UpdateAsync(DealDto dealDto);
    Task DeleteAsync(int id);
    Task<GetDealDto> MarkDealAsWonAsync(int dealId);
    Task<GetDealDto> MarkDealAsLostAsync(int dealId);
    Task<DealStatisticsDto> GetDealStatisticsAsync();

    Task<GetDealProductDto?> GetDealProductByIdAsync(int dealProductId);
    Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp);
    Task<GetDealProductDto> AddProductToDealAsync(AddDealProductDto addDealProductDto);
    Task<GetDealProductDto> UpdateDealProductAsync(UpdateDealProductDto updateDealProductDto);
    Task DeleteDealProductAsync(int dealProductId);
}
