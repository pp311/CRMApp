using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Deal;

public class GetDealDto
{
    public int Id { get; set; }

    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string Title { get; set; } = null!;

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }

    public double? EstimatedRevenue { get; set; }

    public double? ActualRevenue { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus Status { get; set; }
}
