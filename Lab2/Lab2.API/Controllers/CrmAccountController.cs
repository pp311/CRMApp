using Lab2.Application.Commons.Permissions;
using Lab2.Application.DTOs.Account;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Commons.Attributes;
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
    [HasPermission(PermissionPolicy.AccountPermission.View)]
    public async Task<ActionResult<GetAccountDto>> GetAccountById(int accountId)
    {
        var accountDto = await _accountService.GetByIdAsync(accountId);
        return accountDto == null ? NotFound() : Ok(accountDto);
    }

    [HttpGet]
    [HasPermission(PermissionPolicy.AccountPermission.View)]
    public async Task<ActionResult<PagedResult<GetAccountDto>>> GetAccountList([FromQuery] AccountQueryParameters accountQueryParameters)
    {
        return Ok(await _accountService.GetListAsync(accountQueryParameters));
    }

    [HttpPost]
    [HasPermission(PermissionPolicy.AccountPermission.Create)]
    public async Task<ActionResult<GetAccountDto>> CreateAccount([FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        var createdAccount = await _accountService.CreateAsync(accountDto);
        return CreatedAtAction(nameof(GetAccountById), new { accountId = createdAccount.Id }, createdAccount);
    }

    [HttpPut("{accountId:int}")]
    [HasPermission(PermissionPolicy.AccountPermission.Edit)]
    public async Task<ActionResult<GetAccountDto>> UpdateAccount(int accountId, [FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        var updatedAccountDto = await _accountService.UpdateAsync(accountId, accountDto);
        return Ok(updatedAccountDto);
    }

    [HttpDelete("{accountId:int}")]
    [HasPermission(PermissionPolicy.AccountPermission.Delete)]
    public async Task<ActionResult> DeleteAccount(int accountId)
    {
        await _accountService.DeleteAsync(accountId);
        return NoContent();
    }
}
