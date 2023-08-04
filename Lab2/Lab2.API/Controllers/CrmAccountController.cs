using Lab2.Application.DTOs.Account;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Services.Interfaces;
using Lab2.Domain.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/crm-accounts")]
public class CrmAccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public CrmAccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet("{accountId:int}")]
    public async Task<ActionResult<GetAccountDto>> GetAccountById(int accountId)
    {
        var accountDto = await _accountService.GetByIdAsync(accountId);
        return accountDto == null ? NotFound() : Ok(accountDto);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetAccountDto>>> GetAccountList([FromQuery] AccountQueryParameters accountQueryParameters)
    {
        return Ok(await _accountService.GetListAsync(accountQueryParameters));
    }

    [HttpPost]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetAccountDto>> CreateAccount([FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        var createdAccount = await _accountService.CreateAsync(accountDto);
        return CreatedAtAction(nameof(GetAccountById), new { accountId = createdAccount.Id }, createdAccount);
    }

    [HttpPut("{accountId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetAccountDto>> UpdateAccount(int accountId, [FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        var updatedAccountDto = await _accountService.UpdateAsync(accountId, accountDto);
        return Ok(updatedAccountDto);
    }

    [HttpDelete("{accountId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult> DeleteAccount(int accountId)
    {
        await _accountService.DeleteAsync(accountId);
        return NoContent();
    }
}
