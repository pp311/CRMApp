using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.DTOs.QueryParameters;

public class ProductQueryParameters : PagingParameters
{
    [EnumDataType(typeof(ProductType))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType? Type { get; set; }
    
    [EnumDataType(typeof(ProductSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductSortBy? OrderBy { get; set; }
}
