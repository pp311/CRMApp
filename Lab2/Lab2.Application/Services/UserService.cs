using AutoMapper;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.DTOs.User;
using Lab2.Application.Interfaces;
using Lab2.Application.Services.Interfaces;
using Lab2.Domain;
using Lab2.Domain.Constant;
using Lab2.Domain.Entities;
using Lab2.Domain.Exceptions;

namespace Lab2.Application.Services;

public class UserService : IUserService
{
    private readonly IUserManagerService _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public UserService(IUserManagerService userManager, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork; 
        _mapper = mapper;
    }
    
    public async Task<PagedResult<GetUserDto>> GetListAsync(UserQueryParameters uqp)
    {
        var (list, totalCount) = await _userManager.GetUserPagedListAsync(uqp.Search,
                                                                             orderBy: null,
                                                                             skip: (uqp.PageIndex - 1) * uqp.PageSize,
                                                                             take: uqp.PageSize,
                                                                             isDescending: uqp.IsDescending);
        var userList = _mapper.Map<List<GetUserDto>>(list);
        return new PagedResult<GetUserDto>(userList, totalCount, uqp.PageIndex, uqp.PageSize);
    }
    
    public async Task<GetUserDto?> GetByIdAsync(int id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        return _mapper.Map<GetUserDto>(user);
    }
    
    public async Task<GetUserDto> CreateAsync(CreateUserDto dto)
    {
        // 1. Check if user with the same email exists
        if (await _userManager.FindByEmailAsync(dto.Email) != null)
            throw new InvalidUpdateException($"User with email {dto.Email} already exists");

        var user = _mapper.Map<User>(dto);
        
        try
        {
            await _unitOfWork.BeginTransactionAsync();
            
            // 2. Create user
            user = await _userManager.CreateAsync(user, dto.Password);
            
            // 3. Set role
            await _userManager.AddToRoleAsync(user, AppRole.User);
            
            await _unitOfWork.CommitTransactionAsync();
        }
        catch
        {
            await _unitOfWork.RollbackAsync();
            throw;
        }
        return _mapper.Map<GetUserDto>(user);
    }
    
    public async Task<GetUserDto> UpdateAsync(int id, UpdateUserDto dto)
    {
        // 1. Get user from database
        var user = await _userManager.FindByIdAsync(id.ToString())
                ?? throw new EntityNotFoundException($"User with id {id} not found");
        
        //2. If email changed, check if new email is not taken
        if (user.Email != dto.Email && await _userManager.FindByEmailAsync(dto.Email) != null)
            throw new InvalidUpdateException($"User with email {dto.Email} already exists");
        
        // 3. Update user
        _mapper.Map(dto, user);
        await _userManager.UpdateAsync(user);
        
        return _mapper.Map<GetUserDto>(user);
    }
    
    public async Task DeleteAsync(int id)
    {
        await _userManager.DeleteAsync(id.ToString());
    }

    public async Task ChangePasswordAsync(int userId, ChangePasswordDto dto)
    {
        if (!await _userManager.CheckPasswordAsync(userId.ToString(), dto.OldPassword))
            throw new InvalidUpdateException("Old password is incorrect");
        
        await _userManager.ChangePasswordAsync(userId.ToString(), dto.OldPassword, dto.NewPassword);
    }
}