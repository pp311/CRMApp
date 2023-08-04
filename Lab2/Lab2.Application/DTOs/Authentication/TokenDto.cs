namespace Lab2.Application.DTOs.Authentication;

public class TokenDto
{
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
    // public DateTime AccessTokenExpires { get; set; }
    // public DateTime RefreshTokenExpires { get; set; }
}