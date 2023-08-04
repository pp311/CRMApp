namespace Lab2.Domain.Entities;

public class Contact : AuditableEntity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
    
    public int AccountId { get; set; }
    public Account? Account { get; set; }
}