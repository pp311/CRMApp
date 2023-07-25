using Lab2.DTOs.QueryParameters;
using Lab2.DTOs.User;

namespace Lab2.Services.Interfaces;

public interface IUserService
{
    Task<PagedResult<GetUserDto>> GetListAsync(UserQueryParameters userQueryParameters);
    Task<GetUserDto?> GetByIdAsync(int id);
    Task<GetUserDto> CreateAsync(CreateUserDto dto);
    Task<GetUserDto> UpdateAsync(int id, UpdateUserDto dto);
    Task DeleteAsync(int id);
    Task ChangePasswordAsync(ChangePasswordDto dto);
}