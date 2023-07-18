namespace Lab2.Entities;

public class Product : AuditableEntity
{
    public string ProductCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Type { get; set; }
    public bool IsAvailable { get; set; }
    
    public ICollection<DealProduct> DealProducts { get; set; } = new List<DealProduct>();
}
