using AutoMapper;
using Lab2.Application.DTOs.Role;
using Lab2.Application.Helpers;
using Lab2.Application.Interfaces;
using Lab2.Domain.Entities;

namespace Lab2.Application.Services;

public class RoleService : IRoleService
{
    private readonly IRoleManagerService _roleManager;
    private readonly IMapper _mapper;
    
    public RoleService(IRoleManagerService roleManager, IMapper mapper)
    {
        _roleManager = roleManager;
        _mapper = mapper;
    } 
    
    public async Task<IEnumerable<GetRoleDto>> GetListAsync()
    {
        var roles = await _roleManager.GetAllRolesWithPermissionsAsync();
        return _mapper.Map<IEnumerable<GetRoleDto>>(roles);
    }

    public async Task<GetRoleDto?> GetByIdAsync(int id)
    {
        var role = await _roleManager.GetByIdAsync(id);
        return _mapper.Map<GetRoleDto>(role);
    }

    public async Task<List<string>> GetAllPermissionsAsync()
    {
        var permissions = PermissionHelper.GetAllPermissions();
        return await Task.FromResult(permissions.Select(p => p.Value).ToList());
    }
    
    

    public async Task<GetRoleDto> UpdateAsync(int id, UpdateRoleDto dto)
    {
        var role = _mapper.Map<Role>(dto);
        role.Id = id;
        role = await _roleManager.UpdateAsync(role);
        return _mapper.Map<GetRoleDto>(role);
    }
}