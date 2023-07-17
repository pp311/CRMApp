using Lab2.DTOs.Product;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{productId:int}")]
    public async Task<ActionResult<ProductDto>> GetProductById(int productId)
    {
        // Get product from service, if not found return 404
        var productDto = await _productService.GetByIdAsync(productId);
        if (productDto == null)
        {
            return NotFound();
        }
        return Ok(productDto);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<ProductDto>>> GetProductList([FromQuery] ProductQueryParameters productQueryParameters)
    {
        // Get products from service
        var products = await _productService.GetListAsync(productQueryParameters);
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult<ProductDto>> CreateProduct([FromBody] ProductDto? productDto)
    {
        // 1. Check if dto provided
        if (productDto == null)
            return BadRequest();
        // 2. Create product
        var newProductDto = await _productService.CreateAsync(productDto);
        return CreatedAtAction(nameof(GetProductById), new { productId = newProductDto.Id }, newProductDto);
    }

    [HttpPut("{productId:int}")]
    public async Task<ActionResult<ProductDto>> UpdateProduct(int productId, [FromBody] ProductDto? productDto)
    {
        if (productDto == null)
            return BadRequest();
        productDto.Id = productId;
        
        // Check if product exists
        if (await _productService.GetByIdAsync(productId) == null)
        {
            return NotFound();
        }
        
        // Update product
        var updatedProductDto = await _productService.UpdateAsync(productDto);
        return Ok(updatedProductDto);
    }

    [HttpDelete("{productId:int}")]
    public async Task<ActionResult> DeleteProduct(int productId)
    {
        await _productService.DeleteAsync(productId);
        return NoContent();
    }
}
