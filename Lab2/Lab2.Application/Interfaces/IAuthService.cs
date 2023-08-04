using Lab2.Application.DTOs.Authentication;

namespace Lab2.Application.Interfaces;

public interface IAuthService
{
    Task<TokenDto> LoginAsync(LoginDto loginDto);
    Task<TokenDto> CreateTokenFromRefreshTokenAsync(string refreshToken);
    Task RevokeRefreshTokenAsync(string refreshToken);
}