using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IDealService
{
    Task<GetDealDto?> GetByIdAsync(int id);
    Task<PagedResult<DealDto>> GetListAsync(DealQueryParameters dqp);
    // Task<DealDto> CreateAsync(DealDto deal);
    Task<DealDto> UpdateAsync(DealDto dealDto);
    Task<bool> DeleteAsync(int id);

    Task<GetDealProductDto?> GetDealProductByIdAsync(int dealId, int dealProductId);
    Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp);
    Task<GetDealProductDto> AddProductToDealAsync(int dealId, AddDealProductDto addDealProductDto);
    Task<GetDealProductDto> UpdateDealProductAsync(UpdateDealProductDto updateDealProductDto);
    Task<bool> DeleteDealProductAsync(int dealId, int dealProductId);
}
