using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(CRMDbContext context) : base(context)
        {
        }
        
        public async Task<(IEnumerable<Account> Items, int TotalCount)> GetAccountPagedListAsync(string? search,
                                                                                                 string? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending,
                                                                                                 Expression<Func<Account, bool>>? condition)
        {
            var query = DbSet.AsNoTracking();
            // 1. Filtering with expression
            if (condition != null)
                query = query.Where(condition);
            
            // 2. Search by name, phone, email
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(search) ||
                                                (c.Phone != null && c.Phone.ToLower().Contains(search)) ||
                                                (c.Email != null && c.Email.ToLower().Contains(search)));
            }
            // 3. Can only sort by name and email
            if (!string.IsNullOrEmpty(orderBy))
            {
                orderBy = orderBy.Trim().ToLower() switch
                {
                    "name" => "Name",
                    "email" => "Email",
                    _ => "Id"
                };
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy);
            }

            return await GetPagedListFromQueryableAsync(query, skip, take);
        }
    }
}
