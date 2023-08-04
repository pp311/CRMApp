using System.Linq.Dynamic.Core;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
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
                                                                                    bool isDescending)
        {
            var query = DbSet.AsNoTracking();
            
            // 1. Search by name and product code
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(search) || p.ProductCode.ToLower().Contains(search));
            }
            // 2. Filter by type
            if (type != null)
                query = query.Where(p => p.Type == (int)type);
            
            // 3. Ordering
            if (orderBy != null)
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy.ToString()!);
            
            // 4. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }

        public async Task<bool> IsProductCodeExistAsync(string productCode, int productId = 0)
        {
            return await DbSet.AnyAsync(p => p.ProductCode == productCode && p.Id != productId);
        }

        public async Task<bool> IsProductExistAsync(int productId)
        {
            return await  DbSet.AnyAsync(p => p.Id == productId);
        }
    }
}
