using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Deal;

public class GetDealDto
{
    public int Id { get; set; }

    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string Title { get; set; } = null!;

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus Status { get; set; }
    
    public double ActualRevenue { get; set; }
}
