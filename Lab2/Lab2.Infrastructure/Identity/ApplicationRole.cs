using Microsoft.AspNetCore.Identity;

namespace Lab2.Infrastructure.Identity;

public class ApplicationRole : IdentityRole<int>
{
    public ICollection<IdentityRoleClaim<int>> Claims { get; set; } = new List<IdentityRoleClaim<int>>();
}