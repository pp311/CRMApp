using Lab2.Application.DTOs.Authentication;
using Lab2.Application.Interfaces;
using Lab2.Domain.Exceptions;

namespace Lab2.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUserManagerService _userManager;
    private readonly ITokenService _tokenService;
    
    public AuthService(IUserManagerService userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }
    
    public async Task<TokenDto> LoginAsync(LoginDto loginDto)
    {
        // 1. Check if user exists
        var user = await _userManager.FindByEmailAsync(loginDto.Email) 
                   ?? throw new EntityNotFoundException($"User with email {loginDto.Email} not found");
        
        // 2. Check if password is correct
        if (!await _userManager.CheckPasswordAsync(user.Id, loginDto.Password))
            throw new InvalidPasswordException("Invalid password");
        
        // 3. Generate token
        var tokenDto = new TokenDto
        {
            AccessToken = await _tokenService.GenerateAccessTokenAsync(user.Id),
            RefreshToken = _tokenService.GenerateRefreshToken()
        };
        
        // 4. Save refresh token
        await _tokenService.UpdateRefreshTokenAsync(user.Id, tokenDto.RefreshToken);

        return tokenDto;
    }

    public async Task<TokenDto> CreateTokenFromRefreshTokenAsync(string refreshToken)
    {
        // 1. Check if user and refreshToken is valid 
        await _tokenService.ValidateRefreshTokenAsync(refreshToken);
        
        // 2. Get user by refresh token
        var user = _userManager.FindByRefreshTokenAsync(refreshToken);
        
        // 3. Generate new access token and refresh token
        var tokenDto = new TokenDto
        {
            AccessToken = await _tokenService.GenerateAccessTokenAsync(user.Id),
            RefreshToken = _tokenService.GenerateRefreshToken()
        };
        
        // 4. Save Refresh token to database
        await _tokenService.UpdateRefreshTokenAsync(user.Id, tokenDto.RefreshToken);
        
        // 5. Return tokenDto
        return tokenDto;
    }

    public async Task RevokeRefreshTokenAsync(string refreshToken)
    {
        // 1. Get user from database
        var user = await _userManager.FindByRefreshTokenAsync(refreshToken)
            ?? throw new InvalidRefreshTokenException("Refresh token is invalid!");
        
        // 2. Remove refresh token
        await _tokenService.UpdateRefreshTokenAsync(user.Id, null);
    }
}