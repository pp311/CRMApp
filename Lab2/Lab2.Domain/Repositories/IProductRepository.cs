using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Domain.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(string? search,
                                                                                    ProductType? type,
                                                                                    ProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending);
        Task<bool> IsProductCodeExistAsync(string productCode, int productId = 0);
        Task<bool> IsProductExistAsync(int productId);
    }
}
