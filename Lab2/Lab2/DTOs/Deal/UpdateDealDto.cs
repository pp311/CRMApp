using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.Deal;

public class UpdateDealDto
{
    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string Title { get; set; } = null!;

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }
}