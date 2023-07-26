using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Lab2.Configuration;
using Lab2.DTOs.Authentication;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
                   ?? throw new EntityNotFoundException($"User with email {loginDto.Email} not found");
        
        // 2. Check if password is correct
        if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            throw new InvalidPasswordException("Invalid password");
        
        // 3. Generate token
        var tokenDto = await GenerateTokenAsync(user);
        
        // 4. Save refresh token
        user.RefreshToken = tokenDto.RefreshToken;
        user.RefreshTokenLifetime = tokenDto.RefreshTokenExpires;
        var result = await _userManager.UpdateAsync(user);
        
        // 5. Return access token and refresh token
        if (result.Succeeded)
            return tokenDto;
        
        var errors = result.Errors.Select(e => e.Description).ToList();
        throw new InvalidUpdateException(string.Join('\n', errors));
    }

    public async Task<TokenDto> CreateTokenFromRefreshTokenAsync(string refreshToken)
    {
        // 1. Get user from database
        var user = await _userManager.Users.SingleOrDefaultAsync(u => u.RefreshToken == refreshToken)
            ?? throw new InvalidRefreshTokenException("Refresh token is invalid!");
        
        // 2. Check if refreshToken is valid 
        if ((user.RefreshToken == null) || (user.RefreshToken != refreshToken) || (user.RefreshTokenLifetime < DateTime.Now))
            throw new InvalidRefreshTokenException("Refresh token is invalid!");

        // 3. Generate new access token and refresh token
        var tokenDto = await GenerateTokenAsync(user);
        
        // 4. Save Refresh token to database
        user.RefreshToken = tokenDto.RefreshToken;
        user.RefreshTokenLifetime = tokenDto.RefreshTokenExpires;
        var result = await _userManager.UpdateAsync(user);
        
        // 5. Return tokenDto
        if (result.Succeeded)
            return tokenDto;
        
        var errors = result.Errors.Select(e => e.Description).ToList();
        throw new InvalidUpdateException(string.Join('\n', errors));
    }

    public async Task RevokeRefreshTokenAsync(string refreshToken)
    {
        // 1. Get user from database
        var user = await _userManager.Users.SingleOrDefaultAsync(u => u.RefreshToken == refreshToken)
            ?? throw new InvalidRefreshTokenException("Refresh token is invalid!");
        
        // 2. Remove refresh token
        user.RefreshToken = null;
        user.RefreshTokenLifetime = null;

        // 3. Save changes
        var result = await _userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description).ToList();
            throw new InvalidUpdateException(string.Join('\n', errors));
        }
    }

    // Helper methods for AuthService
    private async Task<TokenDto> GenerateTokenAsync(User user)
    {
        // 1. Create header and signature 
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        // 2. Create Jwt
        var accessTokenLifetime = DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.AccessTokenExpiryInMinutes));
        var refreshTokenLifetime = DateTime.Now.AddHours(Convert.ToDouble(_jwtSettings.RefreshTokenExpiryInHours));
        
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtSettings.ValidIssuer,
            audience: _jwtSettings.ValidAudience,
            claims: await GetUserClaimListAsync(user),
            expires: accessTokenLifetime,
            signingCredentials: signingCredentials);

        return new TokenDto
        {
            AccessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions),
            AccessTokenExpires = accessTokenLifetime,
            RefreshToken = GenerateRefreshToken(),
            RefreshTokenExpires = refreshTokenLifetime
        };
    }

    private string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }

    private async Task<List<Claim>> GetUserClaimListAsync(User user)
    {
        return new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Email, user.Email!),
            new(ClaimTypes.Role, (await _userManager.GetRolesAsync(user)).First())
        };
    }
}