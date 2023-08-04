using System.Linq.Dynamic.Core;
using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
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
                                                                                bool isDescending)
        {
            return await GetDealPagedListFromQueryableAsync(DbSet.AsQueryable(), search, status, orderBy, skip, take, isDescending);
        }

        public async Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(
                                                                                int accountId,     
                                                                                string? search,
                                                                                DealStatus? status, 
                                                                                DealSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending)
        {
            var query = DbSet.Where(d => d.Lead!.AccountId == accountId);
            return await GetDealPagedListFromQueryableAsync(query, search, status, orderBy, skip, take, isDescending);
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

        private async Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListFromQueryableAsync(IQueryable<Deal> query,
                                                                                           string? search,
                                                                                           DealStatus? status,
                                                                                           DealSortBy? orderBy,
                                                                                           int skip,
                                                                                           int take,
                                                                                           bool isDescending)
        {
            query = query.Include(d => d.Lead).ThenInclude(l => l!.Account).AsNoTracking();
            
            // 1. Search by title
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(d => d.Title.ToLower().Contains(search.Trim().ToLower()));
            
            // 2. Filter by status
            if (status != null)
                query = query.Where(l => l.Status == (int)status);
            
            // 3. Ordering
            if (orderBy != null)
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy.ToString()!);
            
            // 4. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
