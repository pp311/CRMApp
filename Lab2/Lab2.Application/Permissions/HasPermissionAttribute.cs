using Microsoft.AspNetCore.Authorization;

namespace Lab2.Application.Permissions;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(string permission) : base(permission)
    {
    } 
}