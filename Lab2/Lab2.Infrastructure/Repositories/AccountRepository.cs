using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;
using Lab2.Domain.Repositories;
using Lab2.Infrastructure.Data;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.Account;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Repositories
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
            var query = SpecificationEvaluator<Account>.GetQuery(
                query: DbSet.AsNoTracking(),
                specification: new AccountFilterSpecification(search, orderBy, isDescending));
            
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
