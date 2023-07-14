using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class LeadController : ControllerBase
{
    private readonly ILeadService _leadService;

    public LeadController(ILeadService leadService)
    {
        _leadService = leadService;
    }

    [HttpGet("{leadId:int}")]
    public async Task<ActionResult<LeadDto>> GetLeadById(int leadId)
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
    public async Task<ActionResult<PagedResult<LeadDto>>> GetLeadList([FromQuery] LeadQueryParameters leadQueryParameters)
    {
        // Get leads from service
        var leads = await _leadService.GetListAsync(leadQueryParameters);
        return Ok(leads);
    }

    [HttpPost]
    public async Task<ActionResult<LeadDto>> CreateLead([FromBody] AddLeadDto? leadDto)
    {
        // 1. Check if dto provided
        if (leadDto == null)
            return BadRequest();
        // 2. Create lead    
        var createdLead = await _leadService.CreateAsync(leadDto);
        return CreatedAtAction(nameof(GetLeadById), new { leadId = createdLead.Id }, createdLead);
    }

    [HttpPut("{leadId:int}")]
    public async Task<ActionResult<LeadDto>> UpdateLead(int leadId, [FromBody] LeadDto? leadDto)
    {
        // 1. Check:
        // - if dto provided
        // - if dto id is provided and equal to path parameter
        if ((leadDto == null) || (leadDto.Id != default && leadDto.Id != leadId))
            return BadRequest();
        // 2. If dto id is not provided, set it  
        leadDto.Id = leadId;
        // 3. Check if lead exists
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        // 4. Update lead
        var updatedLeadDto = await _leadService.UpdateAsync(leadDto);
        return Ok(updatedLeadDto);
    }

    [HttpDelete("{leadId:int}")]
    public async Task<ActionResult> DeleteLead(int leadId)
    {
        if (await _leadService.DeleteAsync(leadId))
            return NotFound();
        return NoContent();
    }

    [HttpPost("{leadId:int}/qualify-lead")]
    public async Task<ActionResult<DealDto>> QualifyLead(int leadId)
    {
        // 1. Check if lead exists
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        // 2. Qualify lead
        var deal = await _leadService.QualififyLeadAsync(leadId);
        return CreatedAtRoute("GetDealById", new { leadId = deal.Id }, deal);
    }

    [HttpPost("{leadId:int}/disqualify-lead")]
    public async Task<ActionResult<LeadDto>> DisqualifyLead(int leadId, [FromBody] DisqualifyLeadDto? disqualifyLeadDto)
    {
        // 1. Check if lead exists
        if (await _leadService.GetByIdAsync(leadId) == null)
            return NotFound();
        // 2. Disqualify lead
        var updatedLeadDto = await _leadService.DisqualifyLeadAsync(leadId, disqualifyLeadDto);
        return Ok(updatedLeadDto);
    }
}
