using Lab2.DTOs.Deal;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealController : ControllerBase
{
    private readonly IDealService _dealService;
    private readonly IProductService _productService;

    public DealController(IDealService dealService, IProductService productService)
    {
        _dealService = dealService;
        _productService = productService;
    }

    [HttpGet("{dealId:int}", Name = nameof(GetDealById))]
    public async Task<ActionResult<DealDto>> GetDealById(int dealId)
    {
        var deal = await _dealService.GetByIdAsync(dealId);
        if (deal == null)
        {
            return NotFound();
        }
        return Ok(deal);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<DealDto>>> GetDealList([FromQuery] DealQueryParameters dealQueryParameters)
    {
        var deals = await _dealService.GetListAsync(dealQueryParameters);
        return Ok(deals);
    }

    [HttpPut("{dealId:int}")]
    public async Task<ActionResult<DealDto>> UpdateDeal(int dealId, [FromBody] DealDto? dealDto)
    {
        // 1. Check:
        // - if dto provided
        // - if dto id is provided and equal to path parameter
        if ((dealDto == null) || (dealDto.Id != default && dealDto.Id != dealId))
            return BadRequest();
        // 2. If dto id is not provided, set it
        dealDto.Id = dealId;
        // 3. Update deal
        var updatedDeal = await _dealService.UpdateAsync(dealDto);
        return Ok(updatedDeal);
    }

    [HttpDelete("{dealId:int}")]
    public async Task<ActionResult> DeleteDeal(int dealId)
    {
        if (await _dealService.DeleteAsync(dealId))
        {
            return NoContent();
        }
        return NotFound();
    }

    [HttpGet("{dealId:int}/products")]
    public async Task<ActionResult<PagedResult<GetDealProductDto>>> GetDealProducts(int dealId, [FromQuery] DealProductQueryParameters dealProductQueryParameters)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound();
        var dealProducts = await _dealService.GetDealProductListAsync(dealId, dealProductQueryParameters);
        return Ok(dealProducts);
    }

    [HttpGet("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult<GetDealProductDto>> GetDealProductById(int dealId, int dealProductId)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound();
        // 2. Check if deal product exists
        var dealProduct = await _dealService.GetDealProductByIdAsync(dealId, dealProductId);
        if (dealProduct == null)
            return NotFound();
        return Ok(dealProduct);
    }

    [HttpPost("{dealId:int}/products")]
    public async Task<ActionResult<GetDealProductDto>> AddProductToDeal(int dealId, [FromBody] AddDealProductDto? dealProductDto)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound("Deal not found");
        // 2. Check if dto provided
        if (dealProductDto == null)
            return BadRequest();
        // 3. Check if product exists
        if (await _productService.GetByIdAsync(dealProductDto.ProductId) == null)
            return NotFound("Product not found");
        // 4. Create deal product
        var newDealProductDto = await _dealService.AddProductToDealAsync(dealId, dealProductDto);
        return CreatedAtAction(nameof(GetDealProductById), new { dealId = dealId, dealProductId = newDealProductDto.Id }, newDealProductDto);
    }

    [HttpDelete("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult> DeleteDealProduct(int dealId, int dealProductId)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound("Deal not found");
        // 2. Delete deal product, if false, return 404
        if (await _dealService.DeleteDealProductAsync(dealId, dealProductId))
            return NoContent();
        return NotFound("Deal product not found");
    }

    [HttpPut("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult<GetDealProductDto>> UpdateDealProduct(int dealId, int dealProductId, [FromBody] UpdateDealProductDto? updateDealProductDto)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound("Deal not found");
        // 2. Check if deal product exists
        if (await _dealService.GetDealProductByIdAsync(dealId, dealProductId) == null)
            return NotFound("Deal product not found");
        // 3. Check if dto provided
        if (updateDealProductDto == null)
            return BadRequest();
        // 4. Check if dto id is provided and equal to path parameter
        if (updateDealProductDto.Id != default && updateDealProductDto.Id != dealProductId)
            return BadRequest();
        // 5. If dto id is not provided, set it
        updateDealProductDto.Id = dealProductId;
        updateDealProductDto.DealId = dealId;
        // 6. Check if product exists
        if (await _productService.GetByIdAsync(updateDealProductDto.ProductId) == null)
            return NotFound("Product not found");
        // 7. Update deal product
        var updatedDealProduct = await _dealService.UpdateDealProductAsync(updateDealProductDto);
        return Ok(updatedDealProduct);
    }
    
    [HttpGet("statistics")]
    public async Task<ActionResult<DealStatisticsDto>> GetDealStatistics()
    {
        var dealStatistics = await _dealService.GetDealStatisticsAsync();
        return Ok(dealStatistics);
    }
}
