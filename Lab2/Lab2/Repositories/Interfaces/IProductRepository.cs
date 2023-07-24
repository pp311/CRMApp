using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(string? search,
                                                                                    ProductType? type,
                                                                                    ProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,  
                                                                                    Expression<Func<Product, bool>>? expression = null);
    }
}
