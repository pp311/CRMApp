namespace Lab2.Application.Commons.Configuration;

public class JwtSettings
{
    public string SecurityKey { get; set; } = null!;
    public string ValidIssuer { get; set; } = null!;
    public string ValidAudience { get; set; } = null!;
    public int AccessTokenExpiryInMinutes { get; set; }
    public int RefreshTokenExpiryInHours { get; set; }
    
}