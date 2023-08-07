namespace Lab2.Application.Interfaces;

public interface IRoleManagerService
{
    Task<IEnumerable<string?>> GetRolesAsync();
    Task<IEnumerable<string>> GetPermissionsByRoleAsync(string roleName);
    Task CreateAsync(string roleName);
    Task DeleteAsync(string roleName);
    Task AddPermissionToRoleAsync(string roleName, string permission);
    Task RemovePermissionFromRoleAsync(string roleName, string permission);
}