using System.ComponentModel.DataAnnotations;

namespace Lab2.DTOs.Deal;

public class UpdateDealProductDto
{
    public int Id { get; set; }
    public int DealId { get; set; }
    public int ProductId { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be positive")]
    public int Quantity { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Price per unit must be positive")]
    public double PricePerUnit { get; set; }
}
