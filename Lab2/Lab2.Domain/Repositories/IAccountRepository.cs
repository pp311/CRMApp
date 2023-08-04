using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Domain.Repositories
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        Task<(IEnumerable<Account> Items, int TotalCount)> GetAccountPagedListAsync(string? search,
                                                                                    AccountSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending);
        
        Task<bool> IsEmailDuplicatedAsync(string email, int accountId = 0);
        Task<bool> IsPhoneDuplicatedAsync(string phone, int accountId = 0);
        Task<bool> IsAccountExistAsync(int accountId);
    }
}
