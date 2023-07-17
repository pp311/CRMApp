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
        if (dealDto == null)
            return BadRequest();
        dealDto.Id = dealId;
        
        var updatedDeal = await _dealService.UpdateAsync(dealDto);
        return Ok(updatedDeal);
    }

    [HttpDelete("{dealId:int}")]
    public async Task<ActionResult> DeleteDeal(int dealId)
    {
        await _dealService.DeleteAsync(dealId);
        return NoContent();
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

    [HttpPost("{dealId:int}/products")]
    public async Task<ActionResult<GetDealProductDto>> AddProductToDeal(int dealId, [FromBody] AddDealProductDto? dealProductDto)
    {
        if (dealProductDto == null)
            return BadRequest();
        dealProductDto.DealId = dealId;
        
        var newDealProductDto = await _dealService.AddProductToDealAsync(dealProductDto);
        return CreatedAtRoute("GetDealProductById", new { dealProductId = newDealProductDto.Id }, newDealProductDto);
    }
    
    [HttpPost("{dealId:int}/won")]
    public async Task<ActionResult<GetDealDto>> MarkDealAsWon(int dealId)
    {
        var wonDealDto = await _dealService.MarkDealAsWonAsync(dealId);
        return Ok(wonDealDto);
    }
    
    [HttpPost("{dealId:int}/lost")]
    public async Task<ActionResult<GetDealDto>> MarkDealAsLost(int dealId)
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
}
