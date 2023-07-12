using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lab2.Enums;

namespace Lab2.DTOs.Product;

public class ProductDto
{
    public int Id { get; set; }
    
    [MaxLength((int)StringLength.Short32)]
    public string? ProductCode { get; set; }
    
    [MaxLength((int)StringLength.Medium256)]
    public string? Name { get; set; } = null!;
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType Type { get; set; }
    
    public double Price { get; set; }
    
    public bool IsAvailable { get; set; }
}