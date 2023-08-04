using Lab2.Application.DTOs.Product;
using Lab2.Application.DTOs.QueryParameters;

namespace Lab2.Application.Interfaces;

public interface IProductService
{
    Task<PagedResult<GetProductDto>> GetListAsync(ProductQueryParameters productQueryParameters);
    Task<GetProductDto?> GetByIdAsync(int id);
    Task<GetProductDto> CreateAsync(UpsertProductDto productDto);
    Task<GetProductDto> UpdateAsync(int productId, UpsertProductDto productDto);
    Task DeleteAsync(int productId);
}
