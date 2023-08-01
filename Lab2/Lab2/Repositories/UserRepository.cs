using System.Linq.Dynamic.Core;
using Lab2.Data;
using Lab2.Entities;
using Lab2.Enums.Sorting;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(CRMDbContext context) : base(context)
    {
    }

    public async Task<(IEnumerable<User> Items, int TotalCount)> GetUserPagedListAsync(string? search,
                                                                                       UserSortBy? orderBy,
                                                                                       int skip,
                                                                                       int take,
                                                                                       bool isDescending)
    {
            var query = DbSet.AsNoTracking();
            
            // 1. Search by name and product code
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(u => u.Name.ToLower().Contains(search) || u.Email!.ToLower().Contains(search));
            }
            
            // 2. Sorting
            if (orderBy != null)
                query = isDescending ? query.OrderBy(orderBy + " desc") : query.OrderBy(orderBy.ToString()!);
            
            // 3. Paging
            return await GetPagedListFromQueryableAsync(query, skip, take);
    }
}