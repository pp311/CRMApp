using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(string? search,
                                                                                    ProductType? type,
                                                                                    string? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,  
                                                                                    Expression<Func<Product, bool>>? expression = null)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression
            if (expression != null)
                query = query.Where(expression);
            
            // 2. Search by name and product code
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(search) 
                                         || p.ProductCode.ToLower().Contains(search));
            }
            // 3. Filter by type
            if (type != null)
                query = query.Where(p => p.Type == (int)type);
            
            // 4. Ordering and paging
            return await GetPagedListFromQueryableAsync(query, orderBy, skip, take, isDescending);
        }
    }
}
