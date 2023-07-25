using Lab2.DTOs.QueryParameters;
using Lab2.DTOs.User;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
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
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
    {
        var user = await _userService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetUserById), new {userId = user.Id}, user);
    }
    
    [HttpPut("{userId:int}")]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserDto dto)
    {
        var user = await _userService.UpdateAsync(userId, dto);
        return Ok(user);
    }
    
    [HttpDelete("{userId:int}")]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        await _userService.DeleteAsync(userId);
        return NoContent();
    }
    
    [HttpPost("{userId:int}/change-password")]
    public async Task<IActionResult> ChangePassword(int userId, [FromBody] ChangePasswordDto dto)
    {
        if (await _userService.GetByIdAsync(userId) == null)
            return NotFound();
        
        await _userService.ChangePasswordAsync(dto);
        return NoContent();
    }
}