using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Application.DTOs.QueryParameters;

public class ContactQueryParameters : PagingParameters
{
    [EnumDataType(typeof(ContactSortBy))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ContactSortBy? OrderBy { get; set; }
}
