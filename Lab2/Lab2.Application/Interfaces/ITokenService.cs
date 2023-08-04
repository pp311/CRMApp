namespace Lab2.Application.Interfaces;

public interface ITokenService
{
    string GenerateRefreshToken();

    Task<string> GenerateAccessTokenAsync(string userId);

    Task UpdateRefreshTokenAsync(string userId, string? refreshToken);
}