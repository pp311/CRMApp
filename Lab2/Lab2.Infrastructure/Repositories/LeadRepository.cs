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
    public class LeadRepository : RepositoryBase<Lead>, ILeadRepository
    {
        public LeadRepository(CRMDbContext context) : base(context)
        {
        }
        
        public override async Task<Lead?> GetByIdAsync(int id)
        {
            return await DbSet.Include(l => l.Account).FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(string? search,
                                                                                LeadStatus? status,
                                                                                LeadSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending)
        {
            return await GetLeadPagedListFromQueryableAsync(DbSet.AsQueryable(), search, status, orderBy, skip, take, isDescending);
        }
        
        public async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(int accountId,
                                                                                           string? search,
                                                                                           LeadStatus? status,
                                                                                           LeadSortBy? orderBy,
                                                                                           int skip,
                                                                                           int take,
                                                                                           bool isDescending)
        {
            var query = DbSet.Where(l => l.AccountId == accountId);
            return await GetLeadPagedListFromQueryableAsync(query, search, status, orderBy, skip, take, isDescending);
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

        public async Task<bool> IsLeadExistAsync(int leadId)
        {
            return await DbSet.AnyAsync(l => l.Id == leadId);
        }
        
        private async Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListFromQueryableAsync(
                                                                                IQueryable<Lead> query, 
                                                                                string? search,
                                                                                LeadStatus? status,
                                                                                LeadSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending)
        {
            query = query.Include(l => l.Account).AsNoTracking();
            
            // 1. Search by title
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(l => l.Title.ToLower().Contains(search.Trim().ToLower()));
            
            // 2. Filter by status
            if (status != null)
                query = query.Where(l => l.Status == (int)status);
            
            // 3. Ordering
            if (orderBy != null)
            {
                var sortingField = orderBy.ToString()!;
                if (orderBy == LeadSortBy.AccountName)
                    sortingField = "Account.Name";
                query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);
            } 
            
            // 4. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
