using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.Product;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CrmDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(string? search,
                                                                                    ProductType? type,
                                                                                    ProductSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending)
        {
            var query = SpecificationEvaluator<Product>.GetQuery(
                query: DbSet.AsNoTracking(),
                specification: new ProductFilterSpecification(search, type, orderBy, isDescending));
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
