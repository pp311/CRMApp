using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet("{accountId:int}")]
    public async Task<ActionResult<AccountDto>> GetAccountById(int accountId)
    {
        // Get account from service, if not found return 404
        var accountDto = await _accountService.GetByIdAsync(accountId);
        if (accountDto == null)
        {
            return NotFound();
        }
        return Ok(accountDto);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<AccountDto>>> GetAccountList([FromQuery] AccountQueryParameters accountQueryParameters)
    {
        // Get accounts from service
        var accounts = await _accountService.GetListAsync(accountQueryParameters);
        return Ok(accounts);
    }

    [HttpPost]
    public async Task<ActionResult<AccountDto>> CreateAccount([FromBody] AccountDto? accountDto)
    {
        // 1. Check if dto provided
        if (accountDto == null)
            return BadRequest();
        // 2. Create account    
        var createdAccount = await _accountService.CreateAsync(accountDto);
        return CreatedAtAction(nameof(GetAccountById), new { accountId = createdAccount.Id }, createdAccount);
    }

    [HttpPut("{accountId:int}")]
    public async Task<ActionResult<AccountDto>> UpdateAccount(int accountId, [FromBody] AccountDto? accountDto)
    {
        // 1. Check:
        // - if dto provided
        // - if dto id is provided and equal to path parameter
        if ((accountDto == null) || (accountDto.Id != default && accountDto.Id != accountId))
            return BadRequest();
        // 2. If dto id is not provided, set it  
        accountDto.Id = accountId;
        // 3. Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
            return NotFound();
        // 4. Update account
        var updatedAccountDto = await _accountService.UpdateAsync(accountDto);
        return Ok(updatedAccountDto);
    }

    [HttpDelete("{accountId:int}")]
    public async Task<ActionResult> DeleteAccount(int accountId)
    {
        if (await _accountService.DeleteAsync(accountId))
            return NoContent();
        return NotFound();
    }

    [HttpGet("{accountId:int}/leads")]
    public async Task<ActionResult<PagedResult<LeadDto>>> GetLeadsByAccountId(int accountId, [FromQuery] LeadQueryParameters lqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
        {
            return NotFound();
        }
        // Get leadlist when account exists
        var leads = await _accountService.GetLeadListByAccountIdAsync(accountId, lqp);
        return Ok(leads);
    }

    [HttpGet("{accountId:int}/contacts")]
    public async Task<ActionResult<PagedResult<ContactDto>>> GetContactsByAccountId(int accountId, [FromQuery] ContactQueryParameters cqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
        {
            return NotFound();
        }
        // Get contactlist when account exists
        var contacts = await _accountService.GetContactListByAccountIdAsync(accountId, cqp);
        return Ok(contacts);
    }

    [HttpGet("{accountId:int}/deals")]
    public async Task<ActionResult<PagedResult<DealDto>>> GetDealsByAccountId(int accountId, [FromQuery] DealQueryParameters dqp)
    {
        // Check if account exists
        if (await _accountService.GetByIdAsync(accountId) == null)
        {
            return NotFound();
        }
        // Get deallist when account exists
        var deals = await _accountService.GetDealListByAccountIdAsync(accountId, dqp);
        return Ok(deals);
    }
}
