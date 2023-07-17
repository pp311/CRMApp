using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Lead;

public class GetLeadDto
{
    public int Id { get; set; }
    
    public int AccountId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadSource? Source { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadStatus? Status { get; set; }

    public double EstimatedRevenue { get; set; }

    public DateTime? EndedDate { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadDisqualifiedReason? DisqualifiedReason { get; set; }

    public string? DisqualifiedDescription { get; set; }
}
