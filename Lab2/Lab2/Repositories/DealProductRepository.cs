using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class DealProductRepository : RepositoryBase<DealProduct>, IDealProductRepository
    {
        public DealProductRepository(CRMDbContext context) : base(context)
        {
        }

        public override async Task<DealProduct?> GetByIdAsync(int id)
        {
            return await DbSet.Include(dp => dp.Product)
                            .FirstOrDefaultAsync(dp => dp.Id == id);
        }

        public async Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(string? search,
                                                                                    DealProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    int? dealId)
        {
            var query = DbSet.Include(dp => dp.Product).AsNoTracking();
            // 1. Filtering with condition
            if (dealId != null)
                query = query.Where(dp => dp.DealId == dealId);
            
            // 2. Search by name and product code
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(dp => dp.Product!.Name.ToLower().Contains(search) 
                                          || dp.Product.ProductCode.ToLower().Contains(search));
            }
            // 3. If orderBy provided, check if the orderBy field valid and apply the order 
            if (orderBy == null) 
                return await GetPagedListFromQueryableAsync(query, skip, take);
            
            var sortingField = orderBy switch
            {
                DealProductSortBy.ProductCode => "Product.ProductCode",
                DealProductSortBy.PricePerUnit => DealProductSortBy.PricePerUnit.ToString(),
                DealProductSortBy.Quantity => DealProductSortBy.Quantity.ToString(),
                DealProductSortBy.TotalAmount => "PricePerUnit * Quantity",
                _ => "Product.Name"
            };
            query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);

            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
