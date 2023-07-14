namespace Lab2.DTOs.Deal;

public class GetDealProductDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int DealId { get; set; }
    public string ProductCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }
    public double PricePerUnit { get; set; }
    public double TotalAmount { get; set; }
}
