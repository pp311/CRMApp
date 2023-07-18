using System.Linq.Expressions;
using Lab2.Entities;

namespace Lab2.Repositories.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        Task<(IEnumerable<Account> Items, int TotalCount)> GetAccountPagedListAsync(string? search,
                                                                                    string? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    Expression<Func<Account, bool>>? condition = null);
    }
}
