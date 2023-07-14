using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Lead;

public class LeadDto
{
    public int Id { get; set; }

    [MaxLength((int)StringLength.Medium256)]
    public string? Title { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadSource? Source { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadStatus Status { get; set; }

    public double? EstimatedRevenue { get; set; }

    public DateTime? EndedDate { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadDisqualifiedReason? DisqualifiedReason { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? DisqualifiedDescription { get; set; }
}
