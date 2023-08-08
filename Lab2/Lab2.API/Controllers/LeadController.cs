using Lab2.Application.Commons.Permissions;
using Lab2.Application.DTOs.Deal;
using Lab2.Application.DTOs.Lead;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Commons.Attributes;
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
    [HasPermission(PermissionPolicy.LeadPermission.View)]
    public async Task<ActionResult<GetLeadDto>> GetLeadById(int leadId)
    {
        var leadDto = await _leadService.GetByIdAsync(leadId);
        return leadDto == null ? NotFound() : Ok(leadDto); 
    }

    [HttpGet]
    [HasPermission(PermissionPolicy.LeadPermission.View)]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadList([FromQuery] LeadQueryParameters leadQueryParameters)
    {
        return Ok(await _leadService.GetListAsync(leadQueryParameters));
    }
    
    [HttpGet("account/{accountId:int}")]
    [HasPermission(PermissionPolicy.LeadPermission.View)]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadList(int accountId, [FromQuery] LeadQueryParameters lqp)
    {
        return Ok(await _leadService.GetLeadListByAccountIdAsync(accountId, lqp));
    }

    [HttpPost]
    [HasPermission(PermissionPolicy.LeadPermission.Create)]
    public async Task<ActionResult<GetLeadDto>> CreateLead([FromBody] AddLeadDto? leadDto)
    {
        if (leadDto == null)
            return BadRequest();
        
        var createdLead = await _leadService.CreateAsync(leadDto);
        return CreatedAtAction(nameof(GetLeadById), new { leadId = createdLead.Id }, createdLead);
    }

    [HttpPut("{leadId:int}")]
    [HasPermission(PermissionPolicy.LeadPermission.Edit)]
    public async Task<ActionResult<GetLeadDto>> UpdateLead(int leadId, [FromBody] UpdateLeadDto? leadDto)
    {
        if (leadDto == null)
            return BadRequest();
        
        var updatedLeadDto = await _leadService.UpdateAsync(leadId, leadDto);
        return Ok(updatedLeadDto);
    }

    [HttpDelete("{leadId:int}")]
    [HasPermission(PermissionPolicy.LeadPermission.Delete)]
    public async Task<ActionResult> DeleteLead(int leadId)
    {
        await _leadService.DeleteAsync(leadId);
        return NoContent();
    }

    [HttpPost("{leadId:int}/qualify-lead")]
    [HasPermission(PermissionPolicy.LeadPermission.Qualify)]
    public async Task<ActionResult<GetDealDto>> QualifyLead(int leadId)
    {
        var deal = await _leadService.QualifyLeadAsync(leadId);
        return CreatedAtRoute( new { dealId = deal.Id, controller = "Deal", action = nameof(DealController.GetDealById) }, deal);
    }

    [HttpPost("{leadId:int}/disqualify-lead")]
    [HasPermission(PermissionPolicy.LeadPermission.Disqualify)]
    public async Task<ActionResult<GetLeadDto>> DisqualifyLead(int leadId, [FromBody] DisqualifyLeadDto? disqualifyLeadDto)
    {
        var updatedLeadDto = await _leadService.DisqualifyLeadAsync(leadId, disqualifyLeadDto);
        return Ok(updatedLeadDto);
    }
    
    [HttpGet("statistics")]
    [HasPermission(PermissionPolicy.LeadPermission.View)]
    public async Task<ActionResult<LeadStatisticsDto>> GetLeadStatistics()
    {
        return Ok(await _leadService.GetLeadStatisticsAsync());
    }
}

