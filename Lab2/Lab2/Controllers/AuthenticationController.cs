using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Lab2.DTOs.Authentication;
using Lab2.Entities;
using Lab2.Services;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
    
}