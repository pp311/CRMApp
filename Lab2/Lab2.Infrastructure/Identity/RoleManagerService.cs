using System.Security.Claims;
using Lab2.Application.Interfaces;
using Lab2.Application.Permissions;
using Lab2.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Identity;

public class RoleManagerService : IRoleManagerService
{
    private readonly RoleManager<IdentityRole<int>> _roleManager;
    
    public RoleManagerService(RoleManager<IdentityRole<int>> roleManager)
    {
        _roleManager = roleManager;
    }
    
    public async Task<IEnumerable<string?>> GetRolesAsync()
    {
        return await _roleManager.Roles.Select(x => x.Name).ToListAsync();
    }

    public async Task<IEnumerable<string>> GetPermissionsByRoleAsync(string roleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName)
                   ?? throw new EntityNotFoundException($"Role {roleName} not found");
        
        var claims = await _roleManager.GetClaimsAsync(role); 
        return claims.Select(x => x.Value); 
    }

    public async Task CreateAsync(string roleName)
    {
        if(await _roleManager.RoleExistsAsync(roleName))
            throw new EntityAlreadyExistsException($"Role {roleName} already exists");
        
        await _roleManager.CreateAsync(new IdentityRole<int>(roleName));    
    }

    public async Task DeleteAsync(string roleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName)
                   ?? throw new EntityNotFoundException($"Role {roleName} not found");
        
        await _roleManager.DeleteAsync(role); 
    }

    public async Task AddPermissionToRoleAsync(string roleName, string permission)
    {
        var role = await _roleManager.FindByNameAsync(roleName)
                   ?? throw new EntityNotFoundException($"Role {roleName} not found");
        
        await _roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, permission));
    }

    public async Task RemovePermissionFromRoleAsync(string roleName, string permission)
    {
        var role = await _roleManager.FindByNameAsync(roleName)
                   ?? throw new EntityNotFoundException($"Role {roleName} not found");
        
        await _roleManager.RemoveClaimAsync(role, new Claim(CustomClaimTypes.Permission, permission));
    }
}