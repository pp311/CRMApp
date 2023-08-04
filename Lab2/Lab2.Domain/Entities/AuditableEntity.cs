namespace Lab2.Domain.Entities;

public class AuditableEntity : EntityBase
{
    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
}