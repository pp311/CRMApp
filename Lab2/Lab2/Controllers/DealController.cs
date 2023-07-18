using Lab2.DTOs.Deal;
using Lab2.DTOs.DealProduct;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealController : ControllerBase
{
    private readonly IDealService _dealService;
    private readonly IDealProductService _dealProductService;

    public DealController(IDealService dealService, IDealProductService dealProductService)
    {
        _dealService = dealService;
        _dealProductService = dealProductService;
    }

    [HttpGet("{dealId:int}")]
    public async Task<ActionResult<GetDealDto>> GetDealById(int dealId)
    {
        var deal = await _dealService.GetByIdAsync(dealId);
        if (deal == null)
        {
            return NotFound();
        }
        return Ok(deal);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetDealDto>>> GetDealList([FromQuery] DealQueryParameters dealQueryParameters)
    {
        var deals = await _dealService.GetListAsync(dealQueryParameters);
        return Ok(deals);
    }

    [HttpPut("{dealId:int}")]
    public async Task<ActionResult<GetDealDetailDto>> UpdateDeal(int dealId, [FromBody] UpdateDealDto? dealDto)
    {
        if (dealDto == null)
            return BadRequest();
        
        var updatedDeal = await _dealService.UpdateAsync(dealId, dealDto);
        return Ok(updatedDeal);
    }

    [HttpDelete("{dealId:int}")]
    public async Task<ActionResult> DeleteDeal(int dealId)
    {
        await _dealService.DeleteAsync(dealId);
        return NoContent();
    }

    [HttpPost("{dealId:int}/won")]
    public async Task<ActionResult<GetDealDetailDto>> MarkDealAsWon(int dealId)
    {
        var wonDealDto = await _dealService.MarkDealAsWonAsync(dealId);
        return Ok(wonDealDto);
    }
    
    [HttpPost("{dealId:int}/lost")]
    public async Task<ActionResult<GetDealDetailDto>> MarkDealAsLost(int dealId)
    {
        var lostDealDto = await _dealService.MarkDealAsLostAsync(dealId);
        return Ok(lostDealDto);
    }

    [HttpGet("statistics")]
    public async Task<ActionResult<DealStatisticsDto>> GetDealStatistics()
    {
        var dealStatistics = await _dealService.GetDealStatisticsAsync();
        return Ok(dealStatistics);
    }
    
    [HttpGet("{dealId:int}/products")]
    public async Task<ActionResult<PagedResult<GetDealProductDto>>> GetDealProducts(int dealId, [FromQuery] DealProductQueryParameters dealProductQueryParameters)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound();
        
        var dealProducts = await _dealProductService.GetDealProductListAsync(dealId, dealProductQueryParameters);
        return Ok(dealProducts);
    }

    [HttpPost("{dealId:int}/products")]
    public async Task<ActionResult<GetDealProductDto>> AddProductToDeal(int dealId, [FromBody] AddDealProductDto? dealProductDto)
    {
        if (dealProductDto == null)
            return BadRequest();
        
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound();
        
        var newDealProductDto = await _dealProductService.AddProductToDealAsync(dealId, dealProductDto);
        return CreatedAtAction( nameof(GetDealProductById),new { dealId, dealProductId = newDealProductDto.Id }, newDealProductDto);
    }
    
    [HttpDelete("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult> DeleteDealProduct(int dealProductId, int dealId)
    {
        var dealProduct = await _dealProductService.GetDealProductByIdAsync(dealProductId);
        var deal = await _dealService.GetByIdAsync(dealId);
        
        // Check if dealProduct exists and if it belongs to the deal
        if (dealProduct == null || deal == null || dealProduct.DealId != dealId)
            return NotFound();
        
        await _dealProductService.DeleteDealProductAsync(dealProductId);
        return NoContent();
    }

    [HttpGet("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult<GetDealProductDto>> GetDealProductById(int dealId, int dealProductId)
    {
        var dealProduct = await _dealProductService.GetDealProductByIdAsync(dealProductId);
        var deal = await _dealService.GetByIdAsync(dealId);
        
        // Check if dealProduct exists and if it belongs to the deal
        if (dealProduct == null || deal == null || dealProduct.DealId != dealId)
            return NotFound();
        
        return Ok(dealProduct);
    }
    
    [HttpPut("{dealId:int}/products/{dealProductId:int}")]
    public async Task<ActionResult<GetDealProductDto>> UpdateDealProduct(int dealId, int dealProductId, [FromBody] UpdateDealProductDto? updateDealProductDto)
    {
        if (updateDealProductDto == null)
            return BadRequest();

        var dealProduct = await _dealProductService.GetDealProductByIdAsync(dealProductId);
        var deal = await _dealService.GetByIdAsync(dealId);
        
        // Check if dealProduct exists and if it belongs to the deal
        if (dealProduct == null || deal == null || dealProduct.DealId != dealId)
            return NotFound();
        
        var updatedDealProduct = await _dealProductService.UpdateDealProductAsync(dealProductId, updateDealProductDto);
        return Ok(updatedDealProduct);
    }
}
