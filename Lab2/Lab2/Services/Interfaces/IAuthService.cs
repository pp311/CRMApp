using Lab2.DTOs.Authentication;

namespace Lab2.Services.Interfaces;

public interface IAuthService
{
    Task<TokenDto> LoginAsync(LoginDto loginDto);
    Task<TokenDto> CreateTokenFromRefreshTokenAsync(string refreshToken);
    Task RevokeRefreshTokenAsync(string refreshToken);
}