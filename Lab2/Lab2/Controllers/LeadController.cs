using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
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
        // Get lead from service, if not found return 404
        var leadDto = await _leadService.GetByIdAsync(leadId);
        if (leadDto == null)
        {
            return NotFound();
        }
        return Ok(leadDto);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadList([FromQuery] LeadQueryParameters leadQueryParameters)
    {
        // Get leads from service
        var leads = await _leadService.GetListAsync(leadQueryParameters);
        return Ok(leads);
    }

    [HttpPost]
    public async Task<ActionResult<GetLeadDto>> CreateLead([FromBody] AddLeadDto? leadDto)
    {
        // 1. Check if dto provided
        if (leadDto == null)
            return BadRequest();
        // 2. Create lead    
        var createdLead = await _leadService.CreateAsync(leadDto);
        return CreatedAtAction(nameof(GetLeadById), new { leadId = createdLead.Id }, createdLead);
    }

    [HttpPut("{leadId:int}")]
    public async Task<ActionResult<GetLeadDto>> UpdateLead(int leadId, [FromBody] UpdateLeadDto? leadDto)
    {
        if (leadDto == null)
            return BadRequest();
        leadDto.Id = leadId;
        
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        
        var updatedLeadDto = await _leadService.UpdateAsync(leadDto);
        return Ok(updatedLeadDto);
    }

    [HttpDelete("{leadId:int}")]
    public async Task<ActionResult> DeleteLead(int leadId)
    {
        await _leadService.DeleteAsync(leadId);
        return NoContent();
    }

    [HttpPost("{leadId:int}/qualify-lead")]
    public async Task<ActionResult<DealDto>> QualifyLead(int leadId)
    {
        // 1. Check if lead exists
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        // 2. Qualify lead
        var deal = await _leadService.QualifyLeadAsync(leadId);
        return CreatedAtRoute("GetDealById", new { leadId = deal.Id }, deal);
    }

    [HttpPost("{leadId:int}/disqualify-lead")]
    public async Task<ActionResult<GetLeadDto>> DisqualifyLead(int leadId, [FromBody] DisqualifyLeadDto? disqualifyLeadDto)
    {
        // 1. Check if lead exists
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        // 2. Disqualify lead
        var updatedLeadDto = await _leadService.DisqualifyLeadAsync(leadId, disqualifyLeadDto);
        return Ok(updatedLeadDto);
    }
    
    [HttpGet("statistics")]
    public async Task<ActionResult<LeadStatisticsDto>> GetLeadStatistics()
    {
        // Get lead statistics from service
        return Ok(await _leadService.GetLeadStatisticsAsync());
    }
}

