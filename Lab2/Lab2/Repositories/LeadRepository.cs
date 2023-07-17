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
            return await DbSet.AsNoTracking().AsQueryable().Select(lead =>
                new LeadStatisticsDto
                {
                    OpenLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Open),
                    QualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Qualified),
                    DisqualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Disqualified),
                    AverageEstimatedRevenue = DbSet.Average(l => l.EstimatedRevenue),
                }).FirstAsync();
        }

        public async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(string? search,
                                                                                LeadStatus? status,
                                                                                string? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending,
                                                                                Expression<Func<Lead, bool>>? condition = null)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with condition
            if (condition != null)
                query = query.Where(condition);
            
            // 2. Search by title
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(l => l.Title.ToLower().Contains(search.Trim().ToLower()));
            
            // 3. Filter by status
            if (status != null)
                query = query.Where(l => l.Status == (int)status);
            
            // 4. Ordering and paging
            return await GetPagedListFromQueryableAsync(query, orderBy, skip, take, isDescending);
        }
    }
}
