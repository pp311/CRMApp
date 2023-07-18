using Lab2.DTOs.DealProduct;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IDealProductService
{
    Task<GetDealProductDto?> GetDealProductByIdAsync(int dealProductId);
    Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp);
    Task<GetDealProductDto> AddProductToDealAsync(int dealId, AddDealProductDto addDealProductDto);
    Task<GetDealProductDto> UpdateDealProductAsync(int dealProductId, UpdateDealProductDto updateDealProductDto);
    Task DeleteDealProductAsync(int dealProductId);

}
