using System.Security.Claims;
using Lab2.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Lab2.Application.Permissions;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    private readonly IRoleManagerService _roleManager;
    
    public PermissionAuthorizationHandler(IRoleManagerService roleManager)
    {
        _roleManager = roleManager;
    }
    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                   PermissionRequirement requirement)
    {
        var role = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
        
        if (role == null)
            return;
        
        var permissions = await _roleManager.GetPermissionsByRoleAsync(role);
        Console.WriteLine(requirement.Permission);
        if (permissions.Contains(requirement.Permission))
            context.Succeed(requirement);
    }
}