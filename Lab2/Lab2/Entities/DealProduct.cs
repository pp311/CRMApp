namespace Lab2.Entities;

public class DealProduct
{
    public int DealId { get; set; }
    public Deal? Deal { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public double TotalAmount { get; set; }
}