using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.Deal;
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
            return await SpecificationEvaluator<Deal>
                       .GetQuery(query: DbSet.AsQueryable(),
                                 specification: new GetDealByIdSpecification(id))
                       .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<Deal> Items, int TotalCount)> GetDealPagedListAsync(string? search,
                                                                                DealStatus? status, 
                                                                                DealSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending)
        {
            var query = SpecificationEvaluator<Deal>.GetQuery(
                query: DbSet.AsNoTracking(),
                specification: new DealFilterSpecification(search, status, orderBy, isDescending));
            
            return await GetPagedListFromQueryableAsync(query, skip, take);
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
            
            query = SpecificationEvaluator<Deal>.GetQuery(
                query: query.AsNoTracking(),
                specification: new DealFilterSpecification(search, status, orderBy, isDescending));
            
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
