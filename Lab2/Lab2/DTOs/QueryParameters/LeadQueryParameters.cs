using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;
using Lab2.Enums.Sorting;

namespace Lab2.DTOs.QueryParameters;

public class LeadQueryParameters : PagingParameters
{
    [EnumDataType(typeof(LeadStatus))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadStatus? Status { get; set; }
    
    [EnumDataType(typeof(LeadSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LeadSortBy? OrderBy { get; set; }
    
}
