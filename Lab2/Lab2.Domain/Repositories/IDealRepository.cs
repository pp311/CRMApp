using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Domain.Repositories
{
    public interface IDealRepository : IRepositoryBase<Deal>
    {
        Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(string? search,
                                                                                DealStatus? status,
                                                                                DealSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending);
        Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(int accountId,
                                                                              string? search,
                                                                              DealStatus? status,
                                                                              DealSortBy? orderBy,
                                                                              int skip,
                                                                              int take,
                                                                              bool isDescending);
        Task<DealStatisticsModel> GetDealStatisticsAsync();
    }
}
