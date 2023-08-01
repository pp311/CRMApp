using Lab2.Entities;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces;

public interface IUserRepository : IRepositoryBase<User>
{
    Task<(IEnumerable<User> Items, int TotalCount)> GetUserPagedListAsync(string? search,
                                                                          UserSortBy? orderBy,
                                                                          int skip,
                                                                          int take,
                                                                          bool isDescending);
}