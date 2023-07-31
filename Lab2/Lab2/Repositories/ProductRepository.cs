using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(string? search,
                                                                                    ProductType? type,
                                                                                    ProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,  
                                                                                    Expression<Func<Product, bool>>? expression = null)
        {
            var query = DbSet.AsNoTracking();
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
            
            // 4. Early return if no sorting
            if (orderBy == null)
                return await GetPagedListFromQueryableAsync(query, skip, take);
            
            // 5. Sorting
            var sortingField = orderBy switch {
                ProductSortBy.Name => ProductSortBy.Name.ToString(),
                ProductSortBy.ProductCode => ProductSortBy.ProductCode.ToString(),
                ProductSortBy.Price => ProductSortBy.Price.ToString(),
                _ => ProductSortBy.Id.ToString()
            };
            
            query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);
            
            // 6. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }

        public async Task<bool> IsProductCodeExistAsync(string productCode, int productId = 0)
        {
            return await IsExistAsync(p => p.ProductCode == productCode && p.Id != productId);
        }

        public async Task<bool> IsProductExistAsync(int productId)
        {
            return await  IsExistAsync(p => p.Id == productId);
        }
    }
}
