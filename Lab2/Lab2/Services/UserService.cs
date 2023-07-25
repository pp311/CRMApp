using AutoMapper;
using Lab2.Constant;
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
        // 1. Check if user with the same email exists
        if (await _userManager.FindByEmailAsync(dto.Email) != null)
            throw new InvalidUpdateException($"User with email {dto.Email} already exists");
        
        // 2. Create user
        var user = _mapper.Map<User>(dto);
        
        var result = await _userManager.CreateAsync(user, dto.Password);
        
        // 3. Set role
        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, AppRole.User);
        }
        else
        {
            var errors = result.Errors.Select(e => e.Description).ToList();
            throw new InvalidUpdateException(string.Join('\n', errors));
        }
        
        return _mapper.Map<GetUserDto>(user);
    }
    
    public async Task<GetUserDto> UpdateAsync(int id, UpdateUserDto dto)
    {
        // 1. Get user from database
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new EntityNotFoundException($"User with id {id} not found");
        
        //2. If email changed, check if new email is not taken
        if (user.Email != dto.Email && await _userManager.FindByEmailAsync(dto.Email) != null)
            throw new InvalidUpdateException($"User with email {dto.Email} already exists");
        
        // 3. Update user
        _mapper.Map(dto, user);
        var result = await _userManager.UpdateAsync(user);
        
        if (result.Succeeded) 
            return _mapper.Map<GetUserDto>(user);
        
        var errors = result.Errors.Select(e => e.Description).ToList();
        throw new InvalidUpdateException(string.Join("\n", errors));
    }
    
    public async Task DeleteAsync(int id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null)
            throw new EntityNotFoundException($"User with id {id} not found");
        
        var result = await _userManager.DeleteAsync(user);
        
        if (result.Succeeded) 
            return;
        
        var errors = result.Errors.Select(e => e.Description).ToList();
        throw new InvalidUpdateException(string.Join('\n', errors));
    }

    public async Task ChangePasswordAsync(int userId, ChangePasswordDto dto)
    {
        // 1. Check if user exists by email
        var user = await _userManager.FindByIdAsync(userId.ToString()) 
                   ?? throw new EntityNotFoundException("User not found");
        
        // 2. Check if old password is correct
        if (!await _userManager.CheckPasswordAsync(user, dto.OldPassword))
            throw new InvalidUpdateException("Old password is incorrect");
        
        // 3. Change password
        var result = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description).ToList();
            throw new InvalidUpdateException(string.Join('\n', errors));
        }
    }
}