using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<Product> Items, int TotalCount)> GetProductPagedListAsync(ProductQueryParameters pqp, Expression<Func<Product, bool>>? expression)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression, search and type
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (!string.IsNullOrWhiteSpace(pqp.Search))
            {
                pqp.Search = pqp.Search.Trim().ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(pqp.Search) || p.ProductCode.ToLower().Contains(pqp.Search));
            }
            if (pqp.Type != null)
            {
                query = query.Where(p => p.Type == (int)pqp.Type);
            }
            // 2. Ordering and paging
            int skip = (pqp.PageIndex - 1) * pqp.PageSize;
            int take = pqp.PageSize;
            return await GetPagedAndOrderedListAsync(query, pqp.OrderBy, skip, take, pqp.IsDescending);
        }
    }
}
