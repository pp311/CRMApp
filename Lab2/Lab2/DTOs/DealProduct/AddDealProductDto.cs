using System.ComponentModel.DataAnnotations;

namespace Lab2.DTOs.DealProduct;

public class AddDealProductDto
{
    public int ProductId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
    public int Quantity { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Price per unit must be positive")]
    public double PricePerUnit { get; set; }
}

