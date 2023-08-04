using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.Interfaces;

public interface IUserManagerService
{
    Task<IList<string>> GetRolesAsync(string userId);
    
    Task<User?> FindByEmailAsync(string email);
    
    Task<User?> FindByIdAsync(string userId);
    
    Task<User> CreateAsync(User user, string password);
    
    Task AddToRoleAsync(User user, string role);

    Task<User> UpdateAsync(User user);
    
    Task DeleteAsync(string userId);
    
    Task<bool> CheckPasswordAsync(string userId, string password);
    
    Task ChangePasswordAsync(string userId, string oldPassword, string newPassword);
    
    Task UpdateRefreshTokenAsync(string userId, string? refreshToken, DateTime? refreshTokenExpiration);
    
    Task<User> ValidateRefreshTokenAsync(string refreshToken);
    
    Task<User?> FindByRefreshTokenAsync(string refreshToken);
    
    Task<(IEnumerable<User> Items, int TotalCount)> GetUserPagedListAsync(string? search,
                                                                          UserSortBy? orderBy,
                                                                          int skip,
                                                                          int take,
                                                                          bool isDescending);
}