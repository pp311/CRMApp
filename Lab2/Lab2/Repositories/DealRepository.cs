using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DomainModels;
using System.Linq.Dynamic.Core;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class DealRepository : RepositoryBase<Deal>, IDealRepository
    {
        public DealRepository(CRMDbContext context) : base(context)
        {
        }
        
        public override async Task<Deal?> GetByIdAsync(int id)
        {
            return await DbSet.Include(d => d.Lead)
                       .ThenInclude(l => l!.Account)
                       .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(string? search,
                                                                                DealStatus? status, 
                                                                                DealSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending,
                                                                                int? accountId)
        {
            var query = DbSet.Include(d => d.Lead).ThenInclude(l => l!.Account).AsNoTracking();
            // 1. Filtering by account id if provided
            if (accountId != null)
                query = query.Where(d => d.Lead!.AccountId == accountId);
            
            // 2. Search by title
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(d => d.Title.ToLower().Contains(search.Trim().ToLower()));
            
            // 3. Filter by status
            if (status != null)
                query = query.Where(l => l.Status == (int)status);
            
            // 4. Ordering
            if (orderBy == null)
                return await GetPagedListFromQueryableAsync(query, skip, take);
            
            var sortingField = orderBy switch
            {
                DealSortBy.Title => DealSortBy.Title.ToString(),
                _ => DealSortBy.Id.ToString()
            };
            query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);
            
            // 5. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }

        public async Task<DealStatistics> GetDealStatisticsAsync()
        {
            return await DbSet.AsNoTracking().AsQueryable().Select(d => 
                       new DealStatistics
                        {
                            OpenDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Open),
                            WonDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Won),
                            LostDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Lost),
                            AverageRevenue = DbSet.Average(d1 => d1.ActualRevenue),
                            TotalRevenue = DbSet.Sum(d1 => d1.ActualRevenue),
                        }).FirstAsync();
        }
    }
}
