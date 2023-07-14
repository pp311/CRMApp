using System.ComponentModel.DataAnnotations;

namespace Lab2.DTOs.Deal;

public class AddDealProductDto
{
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public double PricePerUnit { get; set; }
}

