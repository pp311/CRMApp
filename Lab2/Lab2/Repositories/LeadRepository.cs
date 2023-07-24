using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.Lead;
using System.Linq.Dynamic.Core;
using Lab2.DomainModels;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class LeadRepository : RepositoryBase<Lead>, ILeadRepository
    {
        public LeadRepository(CRMDbContext context) : base(context)
        {
        }
        
        public override async Task<Lead?> GetByIdAsync(int id)
        {
            return await DbSet.Include(l => l.Account).FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<LeadStatistics> GetLeadStatisticsAsync()
        {
            return await DbSet.AsNoTracking().AsQueryable().Select(lead =>
                new LeadStatistics
                {
                    OpenLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Open),
                    QualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Qualified),
                    DisqualifiedLeadCount = DbSet.Count(l => l.Status == (int)LeadStatus.Disqualified),
                    AverageEstimatedRevenue = DbSet.Average(l => l.EstimatedRevenue),
                }).FirstAsync();
        }

        public async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(string? search,
                                                                                LeadStatus? status,
                                                                                LeadSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending,
                                                                                Expression<Func<Lead, bool>>? condition = null)
        {
            var query = DbSet.Include(l => l.Account).AsNoTracking();
            // 1. Filtering with condition
            if (condition != null)
                query = query.Where(condition);
            
            // 2. Search by title
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(l => l.Title.ToLower().Contains(search.Trim().ToLower()));
            
            // 3. Filter by status
            if (status != null)
                query = query.Where(l => l.Status == (int)status);
            
            // 4. Ordering
            if (orderBy == null) 
                return await GetPagedListFromQueryableAsync(query, skip, take);
            
            var sortingField = orderBy switch
            {
                LeadSortBy.Title => LeadSortBy.Title.ToString(),
                LeadSortBy.AccountName => "Account.Name",
                LeadSortBy.AccountId => LeadSortBy.AccountId.ToString(),
                LeadSortBy.EstimatedRevenue => LeadSortBy.EstimatedRevenue.ToString(),
                LeadSortBy.Source => LeadSortBy.Source.ToString(),
                _ => LeadSortBy.Id.ToString()
            };
            query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);

            // 5. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
