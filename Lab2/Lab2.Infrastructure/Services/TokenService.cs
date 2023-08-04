using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Lab2.Application.Configuration;
using Lab2.Application.Interfaces;
using Lab2.Domain.Exceptions;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Infrastructure.Services;

public class TokenService : ITokenService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtSettings _jwtSettings;


    public TokenService(UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtSettings)
    {
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<string> GenerateAccessTokenAsync(string userId)
    {
        // 1. Create header and signature 
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        // 2. Create Jwt
        var tokenOptions = new JwtSecurityToken(
            issuer: _jwtSettings.ValidIssuer,
            audience: _jwtSettings.ValidAudience,
            claims: await GetUserClaimListAsync(userId),
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_jwtSettings.AccessTokenExpiryInMinutes)),
            signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    public async Task UpdateRefreshTokenAsync(string userId, string? refreshToken)
    {
        var appUser = await _userManager.FindByIdAsync(userId) 
                      ?? throw new EntityNotFoundException($"User with id {userId} not found");
        appUser.RefreshToken = refreshToken;
        appUser.RefreshTokenLifetime = DateTime.UtcNow.AddHours(Convert.ToDouble(_jwtSettings.RefreshTokenExpiryInHours));

        var result = await _userManager.UpdateAsync(appUser);
        
        if (!result.Succeeded)
            throw new Exception(result.Errors.First().Description);
    }

    private async Task<IList<Claim>> GetUserClaimListAsync(string userId)
    {
        var appUser = await _userManager.FindByIdAsync(userId);
        return new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, appUser!.Id.ToString()),
            new(ClaimTypes.Name, appUser.Name),
            new(ClaimTypes.Email, appUser.Email!),
            new(ClaimTypes.Role, (await _userManager.GetRolesAsync(appUser)).First())
        };
    }
}