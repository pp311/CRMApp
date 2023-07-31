using System.Linq.Expressions;
using Lab2.Data;
using System.Linq.Dynamic.Core;
using Lab2.Entities;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(CRMDbContext context) : base(context)
        {
        }

        public override async Task<Contact?> GetByIdAsync(int id)
        {
            return await DbSet.Include(c => c.Account).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(string? search,
                                                                                                 ContactSortBy? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending,
                                                                                                 int? accountId)
        {
            var query = DbSet.Include(c => c.Account).AsNoTracking();
            
            // 1. Filtering by account id if provided
            if (accountId != null)
                query = query.Where(c => c.AccountId == accountId);
            
            // 2. Search by name, phone, email
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(search) ||
                                                (c.Phone != null && c.Phone.ToLower().Contains(search)) ||
                                                c.Email.ToLower().Contains(search));
            }
            
            // 3. Ordering
            if (orderBy == null)
                return await GetPagedListFromQueryableAsync(query, skip, take);

            var sortingField = orderBy switch
            {
                ContactSortBy.Name => ContactSortBy.Name.ToString(),
                ContactSortBy.Phone => ContactSortBy.Phone.ToString(),
                ContactSortBy.Email => ContactSortBy.Email.ToString(),
                _ => ContactSortBy.Id.ToString()
            };
            query = isDescending ? query.OrderBy(sortingField + " desc") : query.OrderBy(sortingField);
            
            // 4. Paging
            return await GetPagedListFromQueryableAsync(query,  skip, take);
        }

        public async Task<bool> IsEmailDuplicatedAsync(string email, int contactId = 0)
        {
            return await IsExistAsync(c => c.Email == email && c.Id != contactId);
        }

        public async Task<bool> IsPhoneDuplicatedAsync(string phone, int contactId = 0)
        {
            return await IsExistAsync(c => c.Phone == phone && c.Id != contactId); 
        }

        public async Task<bool> IsContactExistAsync(int contactId)
        {
            return await IsExistAsync(c => c.Id == contactId); 
        }
    }
}
