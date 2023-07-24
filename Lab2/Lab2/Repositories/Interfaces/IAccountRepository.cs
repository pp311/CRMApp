using System.Linq.Expressions;
using Lab2.Entities;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        Task<(IEnumerable<Account> Items, int TotalCount)> GetAccountPagedListAsync(string? search,
                                                                                    AccountSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    Expression<Func<Account, bool>>? condition = null);
    }
}
