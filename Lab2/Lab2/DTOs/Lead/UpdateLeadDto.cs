using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Lead;

public class UpdateLeadDto
{
    public int AccountId { get; set; }

    [MaxLength((int)StringLength.Medium256)]
    public string? Title { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadSource? Source { get; set; }

    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadStatus? Status { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Estimated revenue must be positive")]
    public double EstimatedRevenue { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadDisqualifiedReason? DisqualifiedReason { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? DisqualifiedDescription { get; set; }
}