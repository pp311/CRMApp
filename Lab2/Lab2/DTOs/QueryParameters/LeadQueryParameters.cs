using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.QueryParameters;

public class LeadQueryParameters : PagingParameters
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadStatus? Status { get; set; }
}
