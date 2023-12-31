using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Domain.Repositories
{
    public interface IDealProductRepository : IRepositoryBase<DealProduct>
    {
        Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(
                                                                                    int dealId, 
                                                                                    string? search,
                                                                                    DealProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending);
    }
}
