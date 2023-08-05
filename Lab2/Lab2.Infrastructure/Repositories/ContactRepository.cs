using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.Contact;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
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
            var query = SpecificationEvaluator<Contact>.GetQuery(
                query: DbSet.AsNoTracking(),
                specification: new ContactFilterSpecification(search, orderBy, isDescending));
            return await GetPagedListFromQueryableAsync(query,  skip, take);
        }
        
        public async Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(int accountId,              
                                                                                                 string? search,
                                                                                                 ContactSortBy? orderBy,
                                                                                                 int skip,
                                                                                                 int take,
                                                                                                 bool isDescending)
        {
            var query = DbSet.Where(c => c.AccountId == accountId);
            
            query = SpecificationEvaluator<Contact>.GetQuery(
                query: query.AsNoTracking(),
                specification: new ContactFilterSpecification(search, orderBy, isDescending));
            
            return await GetPagedListFromQueryableAsync(query,  skip, take);
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
    }
}
