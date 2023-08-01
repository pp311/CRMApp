using System.Linq.Dynamic.Core;
using Lab2.Data;
using Lab2.Entities;
using Lab2.Enums.Sorting;
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
                                                                                                 AccountSortBy? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending)
        {
            var query = DbSet.AsNoTracking();
            
            // 1. Search by name, phone, email
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(search) ||
                                                (c.Phone != null && c.Phone.ToLower().Contains(search)) ||
                                                (c.Email != null && c.Email.ToLower().Contains(search)));
            }
            
            // 2. Sorting
            if (orderBy == null)
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy.ToString()!);

            // 3. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
        }

        public async Task<bool> IsEmailDuplicatedAsync(string email, int accountId)
        {
            return await DbSet.AnyAsync(a => a.Email == email && a.Id != accountId);
        }

        public async Task<bool> IsPhoneDuplicatedAsync(string phone, int accountId)
        {
            return await DbSet.AnyAsync(a => a.Phone == phone && a.Id != accountId);
        }

        public async Task<bool> IsAccountExistAsync(int accountId)
        {
            return await DbSet.AnyAsync(a => a.Id == accountId);
        }
    }
}
