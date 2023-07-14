using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.QueryParameters;

public class DealQueryParameters : PagingParameters
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DealStatus? Status { get; set; }
}

