using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/accounts")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
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
    public async Task<ActionResult<GetAccountDto>> CreateAccount([FromBody] UpsertAccountDto? accountDto)
    {
        // 1. Check if dto provided
        if (accountDto == null)
            return BadRequest();
        // 2. Create account    
        var createdAccount = await _accountService.CreateAsync(accountDto);
        return CreatedAtAction(nameof(GetAccountById), new { accountId = createdAccount.Id }, createdAccount);
    }

    [HttpPut("{accountId:int}")]
    public async Task<ActionResult<GetAccountDto>> UpdateAccount(int accountId, [FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
            return NotFound();
        
        // Update account
        var updatedAccountDto = await _accountService.UpdateAsync(accountId, accountDto);
        return Ok(updatedAccountDto);
    }

    [HttpDelete("{accountId:int}")]
    public async Task<ActionResult> DeleteAccount(int accountId)
    {
        await _accountService.DeleteAsync(accountId);
        return NoContent();
    }

    [HttpGet("{accountId:int}/leads")]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadsByAccountId(int accountId, [FromQuery] LeadQueryParameters lqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
            return NotFound();
        
        // Get lead list when account exists
        var leads = await _accountService.GetLeadListByAccountIdAsync(accountId, lqp);
        return Ok(leads);
    }

    [HttpGet("{accountId:int}/contacts")]
    public async Task<ActionResult<PagedResult<UpsertContactDto>>> GetContactsByAccountId(int accountId, [FromQuery] ContactQueryParameters cqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
            return NotFound();
        
        // Get contact list when account exists
        var contacts = await _accountService.GetContactListByAccountIdAsync(accountId, cqp);
        return Ok(contacts);
    }

    [HttpGet("{accountId:int}/deals")]
    public async Task<ActionResult<PagedResult<GetDealDto>>> GetDealsByAccountId(int accountId, [FromQuery] DealQueryParameters dqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
            return NotFound();
        
        // Get deal list when account exists
        var deals = await _accountService.GetDealListByAccountIdAsync(accountId, dqp);
        return Ok(deals);
    }
}
