using Lab2.Application.DTOs.Product;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Application.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    
    [HttpGet("{productId:int}")]
    [HasPermission(PermissionPolicy.ProductPermission.View)]
    public async Task<ActionResult<GetProductDto>> GetProductById(int productId)
    {
        var productDto = await _productService.GetByIdAsync(productId);
        return productDto == null ? NotFound() : Ok(productDto);
    }

    [HttpGet]
    [HasPermission(PermissionPolicy.ProductPermission.View)]
    public async Task<ActionResult<PagedResult<GetProductDto>>> GetProductList([FromQuery] ProductQueryParameters productQueryParameters)
    {
        var products = await _productService.GetListAsync(productQueryParameters);
        return Ok(products);
    }

    [HttpPost]
    [HasPermission(PermissionPolicy.ProductPermission.Create)]
    public async Task<ActionResult<GetProductDto>> CreateProduct([FromBody] UpsertProductDto? productDto)
    {
        if (productDto == null)
            return BadRequest();
        
        var newProductDto = await _productService.CreateAsync(productDto);
        return CreatedAtAction(nameof(GetProductById), new { productId = newProductDto.Id }, newProductDto);
    }

    [HttpPut("{productId:int}")]
    [HasPermission(PermissionPolicy.ProductPermission.Edit)]
    public async Task<ActionResult<GetProductDto>> UpdateProduct(int productId, [FromBody] UpsertProductDto? productDto)
    {
        if (productDto == null)
            return BadRequest();
        
        var updatedProductDto = await _productService.UpdateAsync(productId, productDto);
        return Ok(updatedProductDto);
    }

    [HttpDelete("{productId:int}")]
    [HasPermission(PermissionPolicy.ProductPermission.Delete)]
    public async Task<ActionResult> DeleteProduct(int productId)
    {
        await _productService.DeleteAsync(productId);
        return NoContent();
    }
}
