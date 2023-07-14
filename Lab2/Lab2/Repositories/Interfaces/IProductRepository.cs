using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;

namespace Lab2.Repositories.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(ProductQueryParameters pqp,
                                                                                    Expression<Func<Product, bool>>? expression = null);
    }
}
