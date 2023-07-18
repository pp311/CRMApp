using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IProductService
{
    Task<PagedResult<GetProductDto>> GetListAsync(ProductQueryParameters productQueryParameters);
    Task<GetProductDto?> GetByIdAsync(int id);
    Task<GetProductDto> CreateAsync(UpsertProductDto productDto);
    Task<GetProductDto> UpdateAsync(int productId, UpsertProductDto productDto);
    Task DeleteAsync(int productId);
}
