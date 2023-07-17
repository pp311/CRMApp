using Lab2.DTOs.Deal;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealProductController : ControllerBase
{
    private readonly IDealService _dealService;
    
    public DealProductController(IDealService dealService)
    {
        _dealService = dealService;
    }
    
    [HttpGet("{dealProductId:int}", Name = nameof(GetDealProductById))]
    public async Task<ActionResult<GetDealProductDto>> GetDealProductById(int dealProductId)
    {
        var dealProduct = await _dealService.GetDealProductByIdAsync(dealProductId);
        if (dealProduct == null)
        {
            return NotFound();
        }
        return Ok(dealProduct);
    }
    
    [HttpDelete("{dealProductId:int}")]
    public async Task<ActionResult> DeleteDealProduct(int dealProductId)
    {
        await _dealService.DeleteDealProductAsync(dealProductId);
        return NoContent();
    }

    [HttpPut("{dealProductId:int}")]
    public async Task<ActionResult<GetDealProductDto>> UpdateDealProduct([FromBody] UpdateDealProductDto? updateDealProductDto)
    {
        if (updateDealProductDto == null)
            return BadRequest();
        
        var updatedDealProduct = await _dealService.UpdateDealProductAsync(updateDealProductDto);
        return Ok(updatedDealProduct);
    }
}