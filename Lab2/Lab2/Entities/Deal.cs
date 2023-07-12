namespace Lab2.Entities;

public class Deal : AuditableEntity
{
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public double? EstimatedRevenue { get; set; }
    public double? ActualRevenue { get; set; }
    public int Status { get; set; }
    
    public int? LeadId { get; set; }
    public virtual Lead? Lead { get; set; }
    public int AccountId { get; set; }
    public virtual Account? Account { get; set; }
    public virtual ICollection<DealProduct> DealProducts { get; set; }
}