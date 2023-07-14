using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
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
            return await DbSet.Include(d => d.Lead).FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(DealQueryParameters dqp, Expression<Func<Deal, bool>>? expression = null)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression, search and status
            if (expression != null)
            {
                query = query.Include(d => d.Lead).Where(expression);
            }
            if (!string.IsNullOrWhiteSpace(dqp.Search))
            {
                dqp.Search = dqp.Search.Trim().ToLower();
                query = query.Where(d => d.Title.ToLower().Contains(dqp.Search));
            }
            if (dqp.Status != null)
            {
                query = query.Where(l => l.Status == (int)dqp.Status);
            }
            // 2. Ordering and paging
            int skip = (dqp.PageIndex - 1) * dqp.PageSize;
            int take = dqp.PageSize;
            return await GetPagedAndOrderedListAsync(query, dqp.OrderBy, skip, take, dqp.IsDescending);
        }

        public async Task<DealStatisticsDto> GetDealStatisticsAsync()
        {
            return await DbSet.AsNoTracking().AsQueryable().Select(d => new DealStatisticsDto
            {
                OpenDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Open),
                WonDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Won),
                LostDealCount = DbSet.Count(d1 => d1.Status == (int)DealStatus.Lost),
                AvarageRevenue = DbSet.Average(d1 => d1.ActualRevenue),
                TotalRevenue = DbSet.Sum(d1 => d1.ActualRevenue),
            }).FirstAsync();
        }
    }
}
