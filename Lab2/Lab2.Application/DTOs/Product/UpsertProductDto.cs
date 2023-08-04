using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Product;

public class UpsertProductDto
{
    [Required]
    [MaxLength((int)StringLength.Short32)]
    public string? ProductCode { get; set; }
    
    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string? Name { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(ProductType))]
    public ProductType Type { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Price must be positive")]
    public double Price { get; set; }
    
    public bool IsAvailable { get; set; }
}