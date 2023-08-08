namespace Lab2.Application.DTOs.Role;

public class GetRoleDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public List<string>? Permissions { get; set; }
}