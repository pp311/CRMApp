namespace Lab2.Entities;

public class Lead : AuditableEntity
{
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public int? Source { get; set; }
    public int Status { get; set; }
    public double? EstimatedRevenue { get; set; }
    public DateTime? EndedDate { get; set; }
    public int? DisqualifiedReason { get; set; }
    public string? DisqualifiedDescription { get; set; }
    
    public int AccountId { get; set; }
    public Account? Account { get; set; }
    public ICollection<Deal> Deals { get; set; }
}