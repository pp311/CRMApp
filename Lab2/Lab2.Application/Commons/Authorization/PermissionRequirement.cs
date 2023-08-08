using Microsoft.AspNetCore.Authorization;

namespace Lab2.Application.Commons.Permissions;

public class PermissionRequirement : IAuthorizationRequirement
{
    public string Permission { get; private set; }

    public PermissionRequirement(string permission)
    {
        Permission = permission;
    } 
}