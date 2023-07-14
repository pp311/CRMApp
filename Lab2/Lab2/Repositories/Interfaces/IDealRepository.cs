using System.Linq.Expressions;
using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;

namespace Lab2.Repositories.Interfaces
{
    public interface IDealRepository : IRepositoryBase<Deal>
    {
        Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(DealQueryParameters dqp, Expression<Func<Deal, bool>>? expression = null);
        Task<DealStatisticsDto> GetDealStatisticsAsync();
    }
}
