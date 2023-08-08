using Lab2.Application.Commons.Permissions;
using Lab2.Application.DTOs.Role;
using Lab2.Application.Interfaces;
using Lab2.Commons.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/roles")]
[Authorize]
public class RoleController : ControllerBase
{
    private readonly IRoleService _roleService;
    
    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }
    
    [HttpGet]
    [HasPermission(PermissionPolicy.RolePermission.View)]
    public async Task<IActionResult> GetRoles()
    {
        return Ok(await _roleService.GetListAsync());
    }
    
    [HttpGet("{roleId:int}")] 
    [HasPermission(PermissionPolicy.RolePermission.View)]
    public async Task<IActionResult> GetRole(int roleId)
    {
        var role = await _roleService.GetByIdAsync(roleId);
        return role == null ? NotFound() : Ok(role);
    }
    
    [HttpGet("permissions")]
    [HasPermission(PermissionPolicy.RolePermission.View)]
    public async Task<IActionResult> GetPermissions()
    {
        return Ok(await _roleService.GetAllPermissionsAsync());
    }
    
    
    [HttpPut("{roleId:int}")]
    [HasPermission(PermissionPolicy.RolePermission.Edit)]
    public async Task<IActionResult> UpdateRole(int roleId, UpdateRoleDto dto)
    {
        var role = await _roleService.UpdateAsync(roleId, dto);
        return Ok(role);
    }
}