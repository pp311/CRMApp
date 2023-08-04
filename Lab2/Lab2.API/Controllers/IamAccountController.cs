using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.DTOs.User;
using Lab2.Application.Interfaces;
using Lab2.Domain.Constant;
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
    public async Task<IActionResult> GetUsers([FromQuery] UserQueryParameters uqp)
    {
        var users = await _userService.GetListAsync(uqp);
        return Ok(users);
    }   
    
    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        var user = await _userService.GetByIdAsync(userId);
        return Ok(user);
    }
    
    [HttpPost]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
    {
        var user = await _userService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetUserById), new {userId = user.Id}, user);
    }
    
    [HttpPut("{userId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOrOwner)]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserDto dto)
    {
        var user = await _userService.UpdateAsync(userId, dto);
        return Ok(user);
    }
    
    [HttpDelete("{userId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        await _userService.DeleteAsync(userId);
        return NoContent();
    }
    
    [HttpPost("{userId:int}/change-password")]
    [Authorize(Policy = AuthPolicy.AdminOrOwner)]
    public async Task<IActionResult> ChangePassword(int userId, [FromBody] ChangePasswordDto dto)
    {
        await _userService.ChangePasswordAsync(userId, dto);
        return NoContent();
    }
}