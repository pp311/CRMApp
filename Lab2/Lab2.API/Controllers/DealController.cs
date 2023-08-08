using Lab2.Application.Commons.Permissions;
using Lab2.Application.DTOs.Deal;
using Lab2.Application.DTOs.DealProduct;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Commons.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/deals")]
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
    [HasPermission(PermissionPolicy.DealPermission.View)]
    public async Task<ActionResult<GetDealDto>> GetDealById(int dealId)
    {
        var deal = await _dealService.GetByIdAsync(dealId);
        return deal == null ? NotFound() : Ok(deal); 
    }

    [HttpGet]
    [HasPermission(PermissionPolicy.DealPermission.View)]
    public async Task<ActionResult<PagedResult<GetDealDto>>> GetDealList([FromQuery] DealQueryParameters dealQueryParameters)
    {
        var deals = await _dealService.GetListAsync(dealQueryParameters);
        return Ok(deals);
    }
    
    [HttpGet("account/{accountId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.View)]
    public async Task<ActionResult<PagedResult<GetDealDto>>> GetDealList(int accountId, [FromQuery] DealQueryParameters dqp)
    {
        return Ok(await _dealService.GetDealListByAccountIdAsync(accountId, dqp));
    }

    [HttpPut("{dealId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.Edit)]
    public async Task<ActionResult<GetDealDetailDto>> UpdateDeal(int dealId, [FromBody] UpdateDealDto? dealDto)
    {
        if (dealDto == null)
            return BadRequest();
        
        var updatedDeal = await _dealService.UpdateAsync(dealId, dealDto);
        return Ok(updatedDeal);
    }

    [HttpDelete("{dealId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.Delete)]
    public async Task<ActionResult> DeleteDeal(int dealId)
    {
        await _dealService.DeleteAsync(dealId);
        return NoContent();
    }

    [HttpPost("{dealId:int}/won")]
    [HasPermission(PermissionPolicy.DealPermission.EndDeal)]
    public async Task<ActionResult<GetDealDetailDto>> MarkDealAsWon(int dealId)
    {
        var wonDealDto = await _dealService.MarkDealAsWonAsync(dealId);
        return Ok(wonDealDto);
    }
    
    [HttpPost("{dealId:int}/lost")]
    [HasPermission(PermissionPolicy.DealPermission.EndDeal)]
    public async Task<ActionResult<GetDealDetailDto>> MarkDealAsLost(int dealId)
    {
        var lostDealDto = await _dealService.MarkDealAsLostAsync(dealId);
        return Ok(lostDealDto);
    }

    [HttpGet("statistics")]
    [HasPermission(PermissionPolicy.DealPermission.View)]
    public async Task<ActionResult<DealStatisticsDto>> GetDealStatistics()
    {
        var dealStatistics = await _dealService.GetDealStatisticsAsync();
        return Ok(dealStatistics);
    }
    
    [HttpGet("{dealId:int}/products")]
    [HasPermission(PermissionPolicy.DealPermission.ViewProduct)]
    public async Task<ActionResult<PagedResult<GetDealProductDto>>> GetDealProducts(int dealId, [FromQuery] DealProductQueryParameters dpqp)
    {
        // 1. Check if deal exists
        if (await _dealService.GetByIdAsync(dealId) == null)
            return NotFound();
        
        var dealProducts = await _dealProductService.GetDealProductListAsync(dealId, dpqp);
        return Ok(dealProducts);
    }

    [HttpPost("{dealId:int}/products")]
    [HasPermission(PermissionPolicy.DealPermission.AddProduct)]
    public async Task<ActionResult<GetDealProductDto>> AddProductToDeal(int dealId, [FromBody] AddDealProductDto? dealProductDto)
    {
        if (dealProductDto == null)
            return BadRequest();
        
        var newDealProductDto = await _dealProductService.AddProductToDealAsync(dealId, dealProductDto);
        return CreatedAtAction( nameof(GetDealProductById),new { dealId, dealProductId = newDealProductDto.Id }, newDealProductDto);
    }
    
    [HttpDelete("{dealId:int}/products/{dealProductId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.DeleteProduct)]
    public async Task<ActionResult> DeleteDealProduct(int dealProductId, int dealId)
    {
        await _dealProductService.DeleteDealProductAsync(dealProductId, dealId);
        return NoContent();
    }

    [HttpGet("{dealId:int}/products/{dealProductId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.ViewProduct)]
    public async Task<ActionResult<GetDealProductDto>> GetDealProductById(int dealId, int dealProductId)
    {
        var dealProduct = await _dealProductService.GetDealProductByIdAsync(dealProductId);
        
        // Check if dealProduct exists and if it belongs to the deal
        if (dealProduct == null || dealProduct.DealId != dealId)
            return NotFound();
        
        return Ok(dealProduct);
    }
    
    [HttpPut("{dealId:int}/products/{dealProductId:int}")]
    [HasPermission(PermissionPolicy.DealPermission.EditProduct)]
    public async Task<ActionResult<GetDealProductDto>> UpdateDealProduct(int dealId, int dealProductId, [FromBody] UpdateDealProductDto? updateDealProductDto)
    {
        if (updateDealProductDto == null)
            return BadRequest();

        var updatedDealProduct = await _dealProductService.UpdateDealProductAsync(dealProductId, dealId, updateDealProductDto);
        return Ok(updatedDealProduct);
    }
}
