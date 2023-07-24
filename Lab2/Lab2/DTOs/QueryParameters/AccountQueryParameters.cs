using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums.Sorting;

namespace Lab2.DTOs.QueryParameters;

public class AccountQueryParameters : PagingParameters
{
    [EnumDataType(typeof(AccountSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AccountSortBy? OrderBy { get; set; } 
}
