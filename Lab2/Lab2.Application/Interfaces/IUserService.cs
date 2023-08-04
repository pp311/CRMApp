using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.DTOs.User;

namespace Lab2.Application.Interfaces;

public interface IUserService
{
    Task<PagedResult<GetUserDto>> GetListAsync(UserQueryParameters userQueryParameters);
    Task<GetUserDto?> GetByIdAsync(int id);
    Task<GetUserDto> CreateAsync(CreateUserDto dto);
    Task<GetUserDto> UpdateAsync(int id, UpdateUserDto dto);
    Task DeleteAsync(int id);
    Task ChangePasswordAsync(int userId, ChangePasswordDto dto);
}