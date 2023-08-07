using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Lab2.Application.Configuration;
using Lab2.Application.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Lab2.Application.CustomServices;

public class TokenService : ITokenService
{
    private readonly IUserManagerService _userManager;
    private readonly JwtSettings _jwtSettings;


    public TokenService(IUserManagerService userManager, IOptions<JwtSettings> jwtSettings)
    {
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }

    public async Task<string> GenerateAccessTokenAsync(int userId)
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

    public async Task UpdateRefreshTokenAsync(int userId, string? refreshToken)
    {
        // Null refresh token means that we want to remove it from database
        // ? : operator requires both expressions to be of the same type
        var refreshTokenLifetime = refreshToken is null 
                                       ? (DateTime?)null
                                       : DateTime.UtcNow.AddHours(Convert.ToDouble(_jwtSettings.RefreshTokenExpiryInHours));
        
        await _userManager.UpdateRefreshTokenAsync(userId, refreshToken, refreshTokenLifetime);
    }

    public async Task ValidateRefreshTokenAsync(string refreshToken)
    {
        var refreshTokenLifetime = await _userManager.GetRefreshTokenLifetimeAsync(refreshToken);
        
        if (refreshTokenLifetime == null)
            throw new Exception("Refresh token not found");
        
        if (refreshTokenLifetime < DateTime.UtcNow)
            throw new Exception("Refresh token expired");
    }

    private async Task<IList<Claim>> GetUserClaimListAsync(int userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        return new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user!.Id.ToString()),
            new(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.Role, (await _userManager.GetRolesAsync(user.Id)).First())
        };
    }
}