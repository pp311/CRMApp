using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces
{
    public interface IDealProductRepository : IRepositoryBase<DealProduct>
    {
        Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(string? search,
                                                                                    DealProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    int? dealId = null);
    }
}
