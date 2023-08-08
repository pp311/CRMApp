using System.Reflection;
using System.Security.Claims;
using Lab2.Application.Commons.Permissions;

namespace Lab2.Application.Helpers;

public static class PermissionHelper
{
    private static List<Claim> _allPermissions = new();
    public static List<Claim> GetAllPermissions()
    {
        if (_allPermissions.Count > 0) return _allPermissions;
        var allPermissions = new List<Claim>();
        var permissionClass = typeof(PermissionPolicy);
        var allModulesPermissions = permissionClass.GetNestedTypes().Where(x => x.IsClass).ToList();
        foreach (var modulePermissions in allModulesPermissions)
        {
            var permissions = modulePermissions.GetFields(BindingFlags.Static | BindingFlags.Public);
            
            if (permissions.Length == 0) continue;
            allPermissions.AddRange(permissions.Select(permission =>
                new Claim(CustomClaimTypes.Permission, permission.GetValue(null)!.ToString()!)));
        }
        
        _allPermissions = allPermissions;
        return _allPermissions;
    }
}