using AutoMapper;
using Lab2.DTOs.QueryParameters;
using Lab2.DTOs.User;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Services;

public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public UserService(UserManager<User> userManager, IUserRepository userRepository, IMapper mapper)
    {
        _userManager = userManager;
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<PagedResult<GetUserDto>> GetListAsync(UserQueryParameters uqp)
    {
        var (list, totalCount) = await _userRepository.GetPagedListAsync(expression: null,
                                                                   orderBy: null,
                                                                   skip: (uqp.PageIndex - 1) * uqp.PageSize,
                                                                   take: uqp.PageSize,
                                                                   isDescending: uqp.IsDescending);
        var userList = _mapper.Map<List<GetUserDto>>(list);
        return new PagedResult<GetUserDto>(userList, totalCount, uqp.PageIndex, uqp.PageSize);
    }
    
    public async Task<GetUserDto?> GetByIdAsync(int id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        return _mapper.Map<GetUserDto>(user);
    }
    
    public async Task<GetUserDto> CreateAsync(CreateUserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        
        var result = await _userManager.CreateAsync(user, dto.Password);
        
        if (result.Succeeded) 
            return _mapper.Map<GetUserDto>(user);
        
        var errors = result.Errors.Select(e => e.Description).ToString() ?? "";
        throw new InvalidUpdateException(errors);
    }
    
    public async Task<GetUserDto> UpdateAsync(int id, UpdateUserDto dto)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new EntityNotFoundException($"User with id {id} not found");
        
        _mapper.Map(dto, user);
        
        var result = await _userManager.UpdateAsync(user);
        
        if (result.Succeeded) 
            return _mapper.Map<GetUserDto>(user);
        
        var errors = result.Errors.Select(e => e.Description).ToString() ?? "";
        throw new InvalidUpdateException(errors);
    }
    
    public async Task DeleteAsync(int id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new EntityNotFoundException($"User with id {id} not found");
        
        var result = await _userManager.DeleteAsync(user);
        
        if (result.Succeeded) 
            return;
        
        var errors = result.Errors.Select(e => e.Description).ToString() ?? "";
        throw new InvalidUpdateException(errors);
    }

    public async Task ChangePasswordAsync(ChangePasswordDto dto)
    {
        // 1. Check if user exists by email
        var user = await _userManager.FindByEmailAsync(dto.Email) 
                   ?? throw new EntityNotFoundException("User not found");
        
        // 2. Check if old password is correct
        if (!await _userManager.CheckPasswordAsync(user, dto.OldPassword))
            throw new InvalidUpdateException("Old password is incorrect");
        
        // 3. Change password
        var result = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description).ToString() ?? "";
            throw new InvalidUpdateException(errors);
        }
    }
}