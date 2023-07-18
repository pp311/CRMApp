using System.Linq.Expressions;
using Lab2.DomainModels;
using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;

namespace Lab2.Repositories.Interfaces
{
    public interface IDealRepository : IRepositoryBase<Deal>
    {
        Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(string? search,
                                                                                DealStatus? status,
                                                                                string? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending,
                                                                                Expression<Func<Deal, bool>>? condition = null);
        Task<DealStatistics> GetDealStatisticsAsync();
    }
}
