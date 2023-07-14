using System.Linq.Expressions;
using Lab2.Data;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(CRMDbContext context) : base(context)
        {
        }

        public async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(ContactQueryParameters cqp, Expression<Func<Contact, bool>>? expression = null)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression and search
            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (!string.IsNullOrWhiteSpace(cqp.Search))
            {
                cqp.Search = cqp.Search.Trim().ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(cqp.Search));
            }
            // 2. Ordering and paging
            int skip = (cqp.PageIndex - 1) * cqp.PageSize;
            int take = cqp.PageSize;
            return await GetPagedAndOrderedListAsync(query, cqp.OrderBy, skip, take, cqp.IsDescending);
        }
    }
}
