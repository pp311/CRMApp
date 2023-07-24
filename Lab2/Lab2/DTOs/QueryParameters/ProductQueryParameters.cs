using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;
using Lab2.Enums.Sorting;

namespace Lab2.DTOs.QueryParameters;

public class ProductQueryParameters : PagingParameters
{
    [EnumDataType(typeof(ProductType))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType? Type { get; set; }
    
    [EnumDataType(typeof(ProductSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductSortBy? OrderBy { get; set; }
}
