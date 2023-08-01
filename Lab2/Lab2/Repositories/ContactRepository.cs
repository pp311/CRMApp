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
                                                                                                 bool isDescending)
        {
            return await GetContactPagedListFromQueryableAsync(DbSet.AsQueryable(), search, orderBy, skip, take, isDescending);
        }
        
        public async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(
                                                                                                 int accountId,              
                                                                                                 string? search,
                                                                                                 ContactSortBy? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending)
        {
            var query = DbSet.AsNoTracking().Where(c => c.AccountId == accountId);
            return await GetContactPagedListFromQueryableAsync(query, search, orderBy, skip, take, isDescending);
        }

        public async Task<bool> IsEmailDuplicatedAsync(string email, int contactId = 0)
        {
            return await DbSet.AnyAsync(c => c.Email == email && c.Id != contactId);
        }

        public async Task<bool> IsPhoneDuplicatedAsync(string phone, int contactId = 0)
        {
            return await DbSet.AnyAsync(c => c.Phone == phone && c.Id != contactId); 
        }

        public async Task<bool> IsContactExistAsync(int contactId)
        {
            return await DbSet.AnyAsync(c => c.Id == contactId); 
        }
        
        private async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListFromQueryableAsync(
                                                                                                 IQueryable<Contact> query, 
                                                                                                 string? search,
                                                                                                 ContactSortBy? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending)
        {
            query = query.Include(c => c.Account).AsNoTracking();
            
            // 1. Search by name, phone, email
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(search) ||
                                                (c.Phone != null && c.Phone.ToLower().Contains(search)) ||
                                                c.Email.ToLower().Contains(search));
            }
            
            // 2. Ordering
            if (orderBy == null)
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy.ToString()!);
            
            // 3. Paging
            return await GetPagedListFromQueryableAsync(query,  skip, take);
        }
    }
}
