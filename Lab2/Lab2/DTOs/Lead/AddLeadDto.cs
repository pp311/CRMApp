
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Lead;

public class AddLeadDto
{
    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string? Title { get; set; }

    [Required]
    public int AccountId { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadSource? Source { get; set; }

    public double? EstimatedRevenue { get; set; }
}
