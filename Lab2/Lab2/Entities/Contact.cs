namespace Lab2.Entities;

public class Contact : AuditableEntity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
    
    public int AccountId { get; set; }
    public virtual Account? Account { get; set; }
}