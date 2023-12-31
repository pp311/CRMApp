namespace Lab2.Domain.Entities;

public class Account : AuditableEntity
{
    public string Name { get; set; } = null!;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public double TotalSales { get; set; }
    
    // public ICollection<Deal> Deals { get; set; }
    public ICollection<Lead> Leads { get; set; } = new List<Lead>();
    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}