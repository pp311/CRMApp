using System.Text.Json.Serialization;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Product;

public class GetProductDto
{
    public int Id { get; set; }
    
    public string? ProductCode { get; set; }
    
    public string? Name { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType Type { get; set; }
    
    public double Price { get; set; }
    
    public bool IsAvailable { get; set; }
}