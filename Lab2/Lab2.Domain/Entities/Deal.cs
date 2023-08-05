namespace Lab2.Domain.Entities;

public class Deal : AuditableEntity
{
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public double ActualRevenue { get; set; }
    public int Status { get; set; }
    public int LeadId { get; set; }
    public Lead? Lead { get; set; }
    public ICollection<DealProduct> DealProducts { get; set; } = new List<DealProduct>();
}
