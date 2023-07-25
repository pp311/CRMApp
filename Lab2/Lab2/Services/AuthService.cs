using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Lab2.Configuration;
using Lab2.DTOs.Authentication;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly JwtSettings _jwtSettings;
    
    public AuthService(UserManager<User> userManager, IOptions<JwtSettings> jwtSettings)
    {
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }
    
    public async Task<TokenDto> LoginAsync(LoginDto loginDto)
    {
        // 1. Check if user exists
        var user = await _userManager.FindByEmailAsync(loginDto.Email) 
                   ?? throw new EntityNotFoundException("User not found");
        
        // 2. Check if password is correct
        if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            throw new InvalidPasswordException("Invalid password");
        
        // 3. Generate JWT token
        return await GenerateJwtToken(user);
    }
    
    private async Task<TokenDto> GenerateJwtToken(User user)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var role = (await _userManager.GetRolesAsync(user)).First();
        
        var accessTokenLifetime = DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.ExpiryInMinutes));
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtSettings.ValidIssuer,
            audience: _jwtSettings.ValidAudience,
            claims: new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, user.Name),
                new(ClaimTypes.Email, user.Email!),
                new(ClaimTypes.Role, role) 
            },
            expires: accessTokenLifetime,
            signingCredentials: signingCredentials);
        
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        var tokenDto = new TokenDto
        {
            AccessToken = tokenString,
            AccessTokenExpires = accessTokenLifetime
        };
        return tokenDto;
    }
}