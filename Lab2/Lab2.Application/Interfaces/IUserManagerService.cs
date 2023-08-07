using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.Interfaces;

public interface IUserManagerService
{
    Task<IList<string>> GetRolesAsync(int userId);
    
    Task<User?> FindByEmailAsync(string email);
    
    Task<User?> FindByIdAsync(int userId);
    
    Task<User> CreateAsync(User user, string password);
    
    Task AddToRoleAsync(int userId, string role);

    Task<User> UpdateAsync(User user);
    
    Task DeleteAsync(int userId);
    
    Task<bool> CheckPasswordAsync(int userId, string password);
    
    Task ChangePasswordAsync(int userId, string oldPassword, string newPassword);
    
    Task<User?> FindByRefreshTokenAsync(string refreshToken);
    
    Task<DateTime?> GetRefreshTokenLifetimeAsync(string refreshToken);
    
    Task UpdateRefreshTokenAsync(int userId, string? refreshToken, DateTime? refreshTokenExpiresUtc); 
    
    Task<(IEnumerable<User> Items, int TotalCount)> GetUserPagedListAsync(string? search,
                                                                          UserSortBy? orderBy,
                                                                          int skip,
                                                                          int take,
                                                                          bool isDescending);
}