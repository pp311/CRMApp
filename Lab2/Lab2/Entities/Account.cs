namespace Lab2.Entities;

public class Account : AuditableEntity
{
    public string Name { get; set; } = null!;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public double TotalSales { get; set; }
    
    public virtual ICollection<Deal> Deals { get; set; }
    public virtual ICollection<Lead> Leads { get; set; }
    public virtual ICollection<Contact> Contacts { get; set; }
}