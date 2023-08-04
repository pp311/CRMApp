namespace Lab2.Application.Interfaces;

public interface ITokenService
{
    string GenerateRefreshToken();

    Task<string> GenerateAccessTokenAsync(int userId);

    Task UpdateRefreshTokenAsync(int userId, string? refreshToken);

    Task ValidateRefreshTokenAsync(string refreshToken);
}