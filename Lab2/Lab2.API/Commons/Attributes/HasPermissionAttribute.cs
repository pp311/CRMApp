using Microsoft.AspNetCore.Authorization;

namespace Lab2.Commons.Attributes;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(string permission) : base(permission)
    {
    } 
}