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

        public async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(string? search,
                                                                                                 string? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending,
                                                                                                 Expression<Func<Contact, bool>>? condition)
        {
            var query = DbSet.AsQueryable();
            // 1. Filtering with expression
            if (condition != null)
                query = query.Where(condition);
            
            // 2. Search by name
            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(c => c.Name.ToLower().Contains(search.Trim().ToLower()));
            
            // 3. Ordering and paging
            return await GetPagedListFromQueryableAsync(query, orderBy, skip, take, isDescending);
        }
    }
}
