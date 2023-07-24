
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums.Sorting;

namespace Lab2.DTOs.QueryParameters;

public class DealProductQueryParameters : PagingParameters
{
    [EnumDataType(typeof(DealProductSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealProductSortBy? OrderBy { get; set; }
    
}
