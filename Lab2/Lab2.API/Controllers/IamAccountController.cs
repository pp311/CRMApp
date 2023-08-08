using System.Security.Claims;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.DTOs.User;
using Lab2.Application.Interfaces;
using Lab2.Application.Permissions;
using Lab2.Domain.Constant;
using Lab2.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/iam-accounts")]
public class IamAccountController : ControllerBase
{
    private readonly IUserService _userService;
    
    public IamAccountController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    [HasPermission(PermissionPolicy.UserPermission.View)]
    public async Task<IActionResult> GetUsers([FromQuery] UserQueryParameters uqp)
    {
        var users = await _userService.GetListAsync(uqp);
        return Ok(users);
    }   
    
    [HttpGet("{userId:int}")]
    [HasPermission(PermissionPolicy.UserPermission.View)]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var user = await _userService.GetByIdAsync(userId);
        return Ok(user);
    }
    
    [HttpPost]
    [HasPermission(PermissionPolicy.UserPermission.Create)]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
    {
        var user = await _userService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetUserById), new {userId = user.Id}, user);
    }
    
    [HttpPut("{userId:int}")]
    [HasPermission(PermissionPolicy.UserPermission.Edit)]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserDto dto)
    {
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;
        
        if (currentUserId != userId && currentUserRole == AppRole.User.ToString())
            return Forbid();
        
        var user = await _userService.UpdateAsync(userId, dto);
        return Ok(user);
    }
    
    [HttpDelete("{userId:int}")]
    [HasPermission(PermissionPolicy.UserPermission.Delete)]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        await _userService.DeleteAsync(userId);
        return NoContent();
    }
    
    [HttpPost("{userId:int}/change-password")]
    [HasPermission(PermissionPolicy.UserPermission.Edit)]
    public async Task<IActionResult> ChangePassword(int userId, [FromBody] ChangePasswordDto dto)
    {
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;
        
        if (currentUserId != userId && currentUserRole == AppRole.User.ToString())
            return Forbid();
        
        await _userService.ChangePasswordAsync(userId, dto);
        return NoContent();
    }
}