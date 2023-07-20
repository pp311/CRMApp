using Microsoft.AspNetCore.Identity;

namespace Lab2.Entities;

public class User : IdentityUser<int>
{
    public string Name { get; set; } = null!;
}