namespace Lab2.DTOs.Deal;

public class UpdateDealProductDto
{
    public int Id { get; set; }
    public int DealId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public double PricePerUnit { get; set; }
}
