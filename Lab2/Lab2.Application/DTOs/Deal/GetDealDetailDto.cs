using System.Text.Json.Serialization;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Deal;

public class GetDealDetailDto
{
    public int Id { get; set; }
    
    public int LeadId { get; set; }
    
    public int AccountId { get; set; }
    
    public string? AccountName { get; set; }
    
    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    public double EstimatedRevenue { get; set; }
    
    public double ActualRevenue { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus Status { get; set; }
}
