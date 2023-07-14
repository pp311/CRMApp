using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;

namespace Lab2.Repositories.Interfaces
{
    public interface IDealProductRepository : IRepositoryBase<DealProduct>
    {
        Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(DealProductQueryParameters dpqp,
                                                                                            Expression<Func<DealProduct, bool>>? expression = null);
        Task<DealProduct?> GetByIdAsync(int dealProductId, int dealId);
    }
}
