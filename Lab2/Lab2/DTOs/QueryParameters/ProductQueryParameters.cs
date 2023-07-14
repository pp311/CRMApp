using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.QueryParameters;

public class ProductQueryParameters : PagingParameters
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType? Type { get; set; }
}
