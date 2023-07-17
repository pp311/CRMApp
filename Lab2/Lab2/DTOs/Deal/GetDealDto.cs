using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Deal;

public class GetDealDto
{
    public int Id { get; set; }
    
    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    public double EstimatedRevenue { get; set; }
    
    public double ActualRevenue { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus Status { get; set; }
}
