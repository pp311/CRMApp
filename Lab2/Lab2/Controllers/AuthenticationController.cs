using Lab2.DTOs.Authentication;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthenticationController(IAuthService authService) 
    {
        _authService = authService;
    }
    
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginDto? loginDto)
    {
        if (loginDto == null)
            return BadRequest();

        return Ok(await _authService.LoginAsync(loginDto));
    }

    [HttpPost("refresh-token")]
    [AllowAnonymous]
    public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenDto? dto)
    {
        if (dto == null)
            return BadRequest();
        return Ok(await _authService.CreateTokenFromRefreshTokenAsync(dto.RefreshToken));
    }

    [HttpPost("revoke-token")]
    public async Task<IActionResult> RevokeRefreshToken([FromBody] RefreshTokenDto? dto)
    {
        if (dto == null)
            return BadRequest();
        await _authService.RevokeRefreshTokenAsync(dto.RefreshToken);
        return NoContent();
    }
}