using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;

namespace Lab2.Services.Interfaces;

public interface IProductService
{
    Task<PagedResult<ProductDto>> GetListAsync(ProductQueryParameters productQueryParameters);
    Task<ProductDto?> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(ProductDto product);
    Task<ProductDto> UpdateAsync(ProductDto product);
    Task DeleteAsync(int id);
}