using Lab2.Domain.Entities;

namespace Lab2.Application.Interfaces;

public interface IRoleManagerService
{
    Task<IEnumerable<Role>> GetAllRolesWithPermissionsAsync();
    Task<Role?> GetByIdAsync(int roleId);
    Task<Role?> GetByNameAsync(string roleName);
    Task<Role> UpdateAsync(Role role);
}