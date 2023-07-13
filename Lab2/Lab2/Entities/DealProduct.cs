namespace Lab2.Entities;

public class DealProduct : AuditableEntity
{
    public int DealId { get; set; }
    public int ProductId { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public Deal? Deal { get; set; }
    public Product? Product { get; set; }
}
