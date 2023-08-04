using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.DTOs.QueryParameters;

public class DealQueryParameters : PagingParameters
{
    [EnumDataType(typeof(DealStatus))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus? Status { get; set; }
    
    [EnumDataType(typeof(DealSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealSortBy? OrderBy { get; set; }
}

