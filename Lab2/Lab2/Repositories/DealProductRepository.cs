using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class DealProductRepository : RepositoryBase<DealProduct>, IDealProductRepository
    {
        public DealProductRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(string? search,
                                                                                    string? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    Expression<Func<DealProduct, bool>>? condition)
        {
            var query = DbSet.Include(dp => dp.Product).AsNoTracking();
            // 1. Filtering with condition
            if (condition != null)
                query = query.Where(condition);
            
            // 2. Search by name and product code
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(dp => dp.Product!.Name.ToLower().Contains(search) 
                                          || dp.Product.ProductCode.ToLower().Contains(search));
            }
            // 3. If orderBy provided, check if the orderBy field valid and apply the order 
            if (!string.IsNullOrEmpty(orderBy))
            {
                orderBy = orderBy.Trim().ToLower() switch
                {
                    "name" => "Product.Name",
                    "productcode" => "Product.ProductCode",
                    "priceperunit" => "PricePerUnit",
                    "quantity" => "Quantity",
                    "totalamount" => "PricePerUnit * Quantity",
                    _ => "Id"
                };
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy);
            }
            // 4. Count total items before paging
            var totalCount = await query.CountAsync();
            // 5. Calculate for paging
            if (skip >= 0 && take > 0)
                query = query.Skip(skip).Take(take);
            
            return (await query.ToListAsync(), totalCount);
        }
    }
}
