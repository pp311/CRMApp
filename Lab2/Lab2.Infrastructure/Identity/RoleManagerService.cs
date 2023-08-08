using AutoMapper;
using Lab2.Application.Helpers;
using Lab2.Application.Interfaces;
using Lab2.Domain.Entities;
using Lab2.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Lab2.Infrastructure.Identity;

public class RoleManagerService : IRoleManagerService
{
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly IMemoryCache _cache;
    private readonly IMapper _mapper;
    
    public RoleManagerService(RoleManager<ApplicationRole> roleManager, IMemoryCache cache, IMapper mapper)
    {
        _roleManager = roleManager;
        _cache = cache;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<Role>> GetAllRolesWithPermissionsAsync()
    {
        var roles = await _roleManager.Roles.AsNoTracking().Include(ar => ar.Claims).ToListAsync();
        return _mapper.Map<List<Role>>(roles);
    }

    public async Task<Role?> GetByIdAsync(int roleId)
    {
        var role = await _roleManager.Roles
                        .Include(ar => ar.Claims)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(ar => ar.Id == roleId);
        
        return _mapper.Map<Role>(role);
    }

    // Implement caching for AuthorizationHandler
    public async Task<Role?> GetByNameAsync(string roleName)
    {
        var role = await _cache.GetOrCreateAsync(
                   key: CacheKeyHelper.GetKey(nameof(RoleManagerService), roleName),
                   entry =>
                   {
                       entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(1));
                       
                       return _roleManager.Roles
                            .Include(ar => ar.Claims)
                            .FirstOrDefaultAsync(ar => ar.Name == roleName);
                   });
        
        return _mapper.Map<Role>(role);
    }

    public async Task<Role> UpdateAsync(Role role)
    {
        var appRole = await _roleManager.Roles.Include(ar => ar.Claims).FirstOrDefaultAsync(ar => ar.Id == role.Id)
                          ?? throw new EntityNotFoundException($"Role with id {role.Id} not found");
       
        _mapper.Map(role, appRole);
        
        var result = await _roleManager.UpdateAsync(appRole);    
        if(!result.Succeeded)
            throw new InvalidUpdateException(result.Errors.First().Description);
        
        // Remove from cache
        _cache.Remove(CacheKeyHelper.GetKey(nameof(RoleManagerService), appRole.Name!));
        
        return _mapper.Map<Role>(appRole);
    }
}