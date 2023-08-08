using System.Security.Claims;
using Lab2.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Lab2.Application.Commons.Permissions;

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
        var roleName = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
        
        if (roleName == null)
            return;
        
        var role = await _roleManager.GetByNameAsync(roleName);
        if (role == null)
            return;
        
        if (role.Claims.Select(c => c.ClaimValue).Contains(requirement.Permission))
            context.Succeed(requirement);
    }
}