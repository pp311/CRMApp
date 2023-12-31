using Lab2.Application.DTOs.DealProduct;
using Lab2.Application.DTOs.QueryParameters;

namespace Lab2.Application.Interfaces;

public interface IDealProductService
{
    Task<GetDealProductDto?> GetDealProductByIdAsync(int dealProductId);
    Task<PagedResult<GetDealProductDto>> GetDealProductListAsync(int dealId, DealProductQueryParameters dpqp);
    Task<GetDealProductDto> AddProductToDealAsync(int dealId, AddDealProductDto addDealProductDto);
    Task<GetDealProductDto> UpdateDealProductAsync(int dealProductId, int dealId, UpdateDealProductDto dealProductDto);
    Task DeleteDealProductAsync(int dealProductId, int dealId);

}
