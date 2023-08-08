using Lab2.Application.DTOs.Role;

namespace Lab2.Application.Interfaces;

public interface IRoleService
{
    Task<IEnumerable<GetRoleDto>> GetListAsync();
    Task<GetRoleDto?> GetByIdAsync(int id);
    Task<List<string>> GetAllPermissionsAsync();
    Task<GetRoleDto> UpdateAsync(int id, UpdateRoleDto dto);
}