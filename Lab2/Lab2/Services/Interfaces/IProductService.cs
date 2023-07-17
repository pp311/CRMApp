using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IProductService
{
    Task<PagedResult<ProductDto>> GetListAsync(ProductQueryParameters productQueryParameters);
    Task<ProductDto?> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(ProductDto productDto);
    Task<ProductDto> UpdateAsync(ProductDto productDto);
    Task DeleteAsync(int productId);
}
