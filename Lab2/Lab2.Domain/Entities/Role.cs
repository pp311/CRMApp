namespace Lab2.Domain.Entities;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<RoleClaim> Claims { get; set; } = new List<RoleClaim>();
}