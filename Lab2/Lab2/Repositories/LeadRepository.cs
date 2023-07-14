using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class LeadRepository : RepositoryBase<Lead>, ILeadRepository
    {
        public LeadRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<LeadStatisticsDto> GetLeadStatisticsAsync()
        {
            return await DbSet.AsNoTracking().AsQueryable().Select(l =>
                new LeadStatisticsDto
                {
                    OpenLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Open),
                    QualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Qualified),
                    DisqualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Disqualified),
                    AvarageEstimatedRevenue = DbSet.Average(l => l.EstimatedRevenue),
                }).FirstAsync();
        }

        public async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(LeadQueryParameters lqp,
                                                                                           Expression<Func<Lead, bool>>? expression = null)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression, search and status
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (!string.IsNullOrWhiteSpace(lqp.Search))
            {
                lqp.Search = lqp.Search.Trim().ToLower();
                query = query.Where(l => l.Title.ToLower().Contains(lqp.Search));
            }
            if (lqp.Status != null)
            {
                query = query.Where(l => l.Status == (int)lqp.Status);
            }
            // 2. Ordering and paging
            int skip = (lqp.PageIndex - 1) * lqp.PageSize;
            int take = lqp.PageSize;
            return await GetPagedAndOrderedListAsync(query, lqp.OrderBy, skip, take, lqp.IsDescending);
        }
    }
}
