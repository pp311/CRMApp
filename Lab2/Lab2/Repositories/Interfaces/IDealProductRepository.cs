using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;

namespace Lab2.Repositories.Interfaces
{
    public interface IDealProductRepository : IRepositoryBase<DealProduct>
    {
        Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(string? search,
                                                                                    string? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    Expression<Func<DealProduct, bool>>? condition = null);
    }
}
