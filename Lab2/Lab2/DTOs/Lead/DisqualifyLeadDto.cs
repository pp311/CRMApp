using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Lead;

public class DisqualifyLeadDto
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadDisqualifiedReason DisqualifiedReason { get; set; }

    [MaxLength((int)StringLength.Long1024)]
    public string? DisqualifiedDescription { get; set; }
}
