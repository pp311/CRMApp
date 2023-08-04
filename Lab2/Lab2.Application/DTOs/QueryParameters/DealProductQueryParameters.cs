using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.DTOs.QueryParameters;

public class DealProductQueryParameters : PagingParameters
{
    [EnumDataType(typeof(DealProductSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealProductSortBy? OrderBy { get; set; }
    
}
