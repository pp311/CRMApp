using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.Lead;
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
            var query = SpecificationEvaluator<Lead>.GetQuery(
                query: DbSet.AsNoTracking(),
                specification: new LeadFilterSpecification(search, status, orderBy, isDescending));
            
            return await GetPagedListFromQueryableAsync(query, skip, take);
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

            query = SpecificationEvaluator<Lead>.GetQuery(
                query: query.AsNoTracking(),
                specification: new LeadFilterSpecification(search, status, orderBy, isDescending));
            
            return await GetPagedListFromQueryableAsync(query, skip, take);
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
    }
}
