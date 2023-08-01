using Lab2.Constant;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/leads")]
public class LeadController : ControllerBase
{
    private readonly ILeadService _leadService;

    public LeadController(ILeadService leadService)
    {
        _leadService = leadService;
    }

    [HttpGet("{leadId:int}")]
    public async Task<ActionResult<GetLeadDto>> GetLeadById(int leadId)
    {
        var leadDto = await _leadService.GetByIdAsync(leadId);
        return leadDto == null ? NotFound() : Ok(leadDto); 
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadList([FromQuery] LeadQueryParameters leadQueryParameters)
    {
        return Ok(await _leadService.GetListAsync(leadQueryParameters));
    }
    
    [HttpGet("account/{accountId:int}")]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadList(int accountId, [FromQuery] LeadQueryParameters lqp)
    {
        return Ok(await _leadService.GetLeadListByAccountIdAsync(accountId, lqp));
    }

    [HttpPost]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetLeadDto>> CreateLead([FromBody] AddLeadDto? leadDto)
    {
        if (leadDto == null)
            return BadRequest();
        
        var createdLead = await _leadService.CreateAsync(leadDto);
        return CreatedAtAction(nameof(GetLeadById), new { leadId = createdLead.Id }, createdLead);
    }

    [HttpPut("{leadId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetLeadDto>> UpdateLead(int leadId, [FromBody] UpdateLeadDto? leadDto)
    {
        if (leadDto == null)
            return BadRequest();
        
        var updatedLeadDto = await _leadService.UpdateAsync(leadId, leadDto);
        return Ok(updatedLeadDto);
    }

    [HttpDelete("{leadId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult> DeleteLead(int leadId)
    {
        await _leadService.DeleteAsync(leadId);
        return NoContent();
    }

    [HttpPost("{leadId:int}/qualify-lead")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetDealDto>> QualifyLead(int leadId)
    {
        var deal = await _leadService.QualifyLeadAsync(leadId);
        return CreatedAtRoute( new { dealId = deal.Id, controller = "Deal", action = nameof(DealController.GetDealById) }, deal);
    }

    [HttpPost("{leadId:int}/disqualify-lead")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetLeadDto>> DisqualifyLead(int leadId, [FromBody] DisqualifyLeadDto? disqualifyLeadDto)
    {
        var updatedLeadDto = await _leadService.DisqualifyLeadAsync(leadId, disqualifyLeadDto);
        return Ok(updatedLeadDto);
    }
    
    [HttpGet("statistics")]
    public async Task<ActionResult<LeadStatisticsDto>> GetLeadStatistics()
    {
        return Ok(await _leadService.GetLeadStatisticsAsync());
    }
}

