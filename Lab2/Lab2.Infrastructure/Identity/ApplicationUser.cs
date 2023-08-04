using Microsoft.AspNetCore.Identity;

namespace Lab2.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<int>
{
    public string Name { get; set; } = null!;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenLifetime { get; set; }
}