using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Lead;

public class AddLeadDto
{
    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string? Title { get; set; }

    public int AccountId { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? Description { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(LeadSource))]
    public LeadSource? Source { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Estimated revenue must be positive")]
    public double EstimatedRevenue { get; set; }
}
