using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Lab2.Application.Configuration;
using Lab2.Application.DTOs.Authentication;
using Lab2.Application.Interfaces;
using Lab2.Domain.Entities;
using Lab2.Domain.Exceptions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUserManagerService _userManager;
    private readonly JwtSettings _jwtSettings;
    
    public AuthService(IUserManagerService userManager, IOptions<JwtSettings> jwtSettings)
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
        if (!await _userManager.CheckPasswordAsync(user.Id.ToString(), loginDto.Password))
            throw new InvalidPasswordException("Invalid password");
        
        // 3. Generate token
        var tokenDto = await GenerateTokensAsync(user);
        
        // 4. Save refresh token
        await _userManager.UpdateRefreshTokenAsync(user.Id.ToString(), tokenDto.RefreshToken, tokenDto.RefreshTokenExpires);

        return tokenDto;
    }

    public async Task<TokenDto> CreateTokenFromRefreshTokenAsync(string refreshToken)
    {
        // 1. Check if user and refreshToken is valid 
        var user = await _userManager.ValidateRefreshTokenAsync(refreshToken);
        
        // 2. Generate new access token and refresh token
        var tokenDto = await GenerateTokensAsync(user);
        
        // 3. Save Refresh token to database
        await _userManager.UpdateRefreshTokenAsync(user.Id.ToString(), tokenDto.RefreshToken, tokenDto.RefreshTokenExpires);
        
        // 4. Return tokenDto
            return tokenDto;
    }

    public async Task RevokeRefreshTokenAsync(string refreshToken)
    {
        // 1. Get user from database
        var user = await _userManager.FindByRefreshTokenAsync(refreshToken)
            ?? throw new InvalidRefreshTokenException("Refresh token is invalid!");
        
        // 2. Remove refresh token
        await _userManager.UpdateRefreshTokenAsync(user.Id.ToString(), null, null);
    }

    // Helper methods for AuthService
    private async Task<TokenDto> GenerateTokensAsync(User user)
    {
        // 1. Create header and signature 
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        // 2. Create Jwt
        var accessTokenLifetime = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_jwtSettings.AccessTokenExpiryInMinutes));
        var refreshTokenLifetime = DateTime.UtcNow.AddHours(Convert.ToDouble(_jwtSettings.RefreshTokenExpiryInHours));
        
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
            new(ClaimTypes.Role, (await _userManager.GetRolesAsync(user.Id.ToString())).First())
        };
    }
}