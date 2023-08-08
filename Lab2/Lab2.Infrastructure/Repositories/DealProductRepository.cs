using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.DealProduct;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
{
    public class DealProductRepository : RepositoryBase<DealProduct>, IDealProductRepository
    {
        public DealProductRepository(CrmDbContext context) : base(context)
        {
        }

        public override async Task<DealProduct?> GetByIdAsync(int id)
        {
            return await DbSet.Include(dp => dp.Product)
                            .FirstOrDefaultAsync(dp => dp.Id == id);
        }

        public async Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(
                                                                                    int dealId,
                                                                                    string? search,
                                                                                    DealProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending)
        {
            var query = DbSet.Where(dp => dp.DealId == dealId);

            query = SpecificationEvaluator<DealProduct>.GetQuery(
                query: query.AsNoTracking(),
                specification: new DealProductFilterSpecification(search, orderBy, isDescending));
            
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
