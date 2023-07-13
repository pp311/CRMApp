namespace Lab2.Entities;

public class Account : AuditableEntity
{
    public string Name { get; set; } = null!;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public double TotalSales { get; set; }
    
    // public ICollection<Deal> Deals { get; set; }
    public ICollection<Lead> Leads { get; set; }
    public ICollection<Contact> Contacts { get; set; }
}