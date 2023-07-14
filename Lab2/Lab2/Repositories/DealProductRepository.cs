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

        public async Task<DealProduct?> GetByIdAsync(int dealProductId, int dealId)
        {
            return await DbSet.Include(dp => dp.Product)
                                         .FirstOrDefaultAsync(dp => dp.Id == dealProductId && dp.DealId == dealId);
        }

        public async Task<(IEnumerable<DealProduct> Items, int TotalCount)> GetDealProductPagedListAsync(DealProductQueryParameters dpqp,
                                                                                                   Expression<Func<DealProduct, bool>>? expression = null)
        {
            var query = DbSet.Include(dp => dp.Product).AsQueryable();
            // 1. Filtering with expression, search and type
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (!string.IsNullOrWhiteSpace(dpqp.Search))
            {
                dpqp.Search = dpqp.Search.Trim().ToLower();
                query = query.Where(dp => dp.Product!.Name.ToLower().Contains(dpqp.Search) || dp.Product.ProductCode.ToLower().Contains(dpqp.Search));
            }
            // 2. Calculate for paging
            int skip = (dpqp.PageIndex - 1) * dpqp.PageSize;
            int take = dpqp.PageSize;

            // 3. If orderBy provided, check if the property exists in TEntity and apply the order 
            if (!string.IsNullOrEmpty(dpqp.OrderBy))
            {
                dpqp.OrderBy = dpqp.OrderBy.Trim().ToLower();
                dpqp.OrderBy = dpqp.OrderBy switch
                {
                    "name" => "Product.Name",
                    "productcode" => "Product.ProductCode",
                    "priceperunit" => "PricePerUnit",
                    "quantity" => "Quantity",
                    "totalamount" => "PricePerUnit * Quantity",
                    _ => null
                };
                if (dpqp.OrderBy == null) return (await query.ToListAsync(), await query.CountAsync());
                // Apply the order, default is ascending
                query = dpqp.IsDescending ? query.OrderBy(dpqp.OrderBy + " desc") : query.OrderBy(dpqp.OrderBy);
            }
            // 4. If skip and take provided, apply them 
            if (skip >= 0 && take >= 0)
            {
                query = query.Skip(skip).Take(take);
            }
            return (await query.ToListAsync(), await query.CountAsync());
        }
    }
}
