namespace Lab2.Domain.Entities;

public class RoleClaim
{
    public int Id { get; set; }
    public string ClaimType { get; set; } = null!;
    public string ClaimValue { get; set; } = null!;
    
    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;
}