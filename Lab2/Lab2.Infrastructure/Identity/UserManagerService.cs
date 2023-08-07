using AutoMapper;
using Lab2.Application.Interfaces;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums.Sorting;
using Lab2.Infrastructure.Specifications;
using Lab2.Infrastructure.Specifications.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Identity;

public class UserManagerService : IUserManagerService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;

    public UserManagerService(UserManager<ApplicationUser> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<IList<string>> GetRolesAsync(int userId)
    {
        return await _userManager.GetRolesAsync(new ApplicationUser { Id = userId });
    }

    public async Task<User?> FindByEmailAsync(string email)
    {
        var appUser = await _userManager.FindByEmailAsync(email);
        return _mapper.Map<User>(appUser); 
    }

    public async Task<User?> FindByIdAsync(int userId)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString());
        return _mapper.Map<User>(appUser);
    }

    public async Task<User> CreateAsync(User user, string password)
    {
        var appUser = _mapper.Map<ApplicationUser>(user);
        var createUserResult = await _userManager.CreateAsync(appUser, password);
        
        if (!createUserResult.Succeeded)
            throw new Exception(createUserResult.Errors.First().Description);
        
        return _mapper.Map<User>(appUser); 
    }

    public async Task AddToRoleAsync(int userId, string role)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new Exception($"User with id {userId} not found");
        
        var addToRoleResult = await _userManager.AddToRoleAsync(appUser, role);
        
        if (!addToRoleResult.Succeeded)
            throw new Exception(addToRoleResult.Errors.First().Description);
    }

    public async Task<User> UpdateAsync(User user)
    {
        var appUser = await _userManager.FindByIdAsync(user.Id.ToString())
            ?? throw new Exception($"User with id {user.Id} not found");

        _mapper.Map(user, appUser);
        
        var updateResult = await _userManager.UpdateAsync(appUser);
        
        if (!updateResult.Succeeded)
            throw new Exception(updateResult.Errors.First().Description);
        
        return _mapper.Map<User>(appUser);
    }

    public async Task DeleteAsync(int userId)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new Exception($"User with id {userId} not found");
        
        var deleteResult = await _userManager.DeleteAsync(appUser);
        
        if (!deleteResult.Succeeded)
            throw new Exception(deleteResult.Errors.First().Description);
    }

    public async Task<bool> CheckPasswordAsync(int userId, string password)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new Exception($"User with id {userId} not found");
        
        return await _userManager.CheckPasswordAsync(appUser, password);
    }

    public async Task ChangePasswordAsync(int userId, string oldPassword, string newPassword)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new Exception($"User with id {userId} not found");
        
        var changePasswordResult = await _userManager.ChangePasswordAsync(appUser, oldPassword, newPassword);
        
        if (!changePasswordResult.Succeeded)
            throw new Exception(changePasswordResult.Errors.First().Description);
    }

    public async Task<User?> FindByRefreshTokenAsync(string refreshToken)
    {
        var appUser = await _userManager.Users
            .FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
        
        return _mapper.Map<User>(appUser);
    }

    public async Task<DateTime?> GetRefreshTokenLifetimeAsync(string refreshToken)
    {
        return await _userManager.Users
            .Where(u => u.RefreshToken == refreshToken)
            .Select(u => u.RefreshTokenLifetime)
            .FirstOrDefaultAsync();
    }

    public async Task UpdateRefreshTokenAsync(int userId, string? refreshToken, DateTime? refreshTokenExpiresUtc)
    {
        var appUser = await _userManager.FindByIdAsync(userId.ToString())
            ?? throw new Exception($"User with id {userId} not found");
        
        (appUser.RefreshToken, appUser.RefreshTokenLifetime) = (refreshToken, refreshTokenExpiresUtc);
        
        var updateResult = await _userManager.UpdateAsync(appUser);
        
        if (!updateResult.Succeeded)
            throw new Exception(updateResult.Errors.First().Description);
    }

    public async Task<(IEnumerable<User> Items, int TotalCount)> GetUserPagedListAsync(string? search,
                                                                                       UserSortBy? orderBy,
                                                                                       int skip,
                                                                                       int take,
                                                                                       bool isDescending)
    {
            var query = SpecificationEvaluator<ApplicationUser>.GetQuery(
                query: _userManager.Users.AsNoTracking(),
                specification: new UserFilterSpecification(search, orderBy, isDescending));
            
            // Paging
            var totalCount = await query.CountAsync();
            
            // If skip and take provided, apply them 
            if (skip >= 0  && take > 0)
                query = query.Skip(skip).Take(take);
            
            return (_mapper.Map<IEnumerable<User>>(await query.ToListAsync()), totalCount);
    }
}