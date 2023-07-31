using Lab2.Constant;
using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/accounts")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    private readonly IDealService _dealService;
    private readonly IContactService _contactService;
    private readonly ILeadService _leadService;


    public AccountController(IAccountService accountService,
                             IDealService dealService,
                             IContactService contactService,
                             ILeadService leadService)
    {
        _accountService = accountService;
        _dealService = dealService;
        _contactService = contactService;
        _leadService = leadService;
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
        // 1. Check if dto provided
        if (accountDto == null)
            return BadRequest();
        // 2. Create account    
        var createdAccount = await _accountService.CreateAsync(accountDto);
        return CreatedAtAction(nameof(GetAccountById), new { accountId = createdAccount.Id }, createdAccount);
    }

    [HttpPut("{accountId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetAccountDto>> UpdateAccount(int accountId, [FromBody] UpsertAccountDto? accountDto)
    {
        if (accountDto == null)
            return BadRequest();
        
        // Update account
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

    [HttpGet("{accountId:int}/leads")]
    public async Task<ActionResult<PagedResult<GetLeadDto>>> GetLeadsByAccountId(int accountId, [FromQuery] LeadQueryParameters lqp)
    {
        var leads = await _leadService.GetLeadListByAccountIdAsync(accountId, lqp);
        return Ok(leads);
    }

    [HttpGet("{accountId:int}/contacts")]
    public async Task<ActionResult<PagedResult<UpsertContactDto>>> GetContactsByAccountId(int accountId, [FromQuery] ContactQueryParameters cqp)
    {
        var contacts = await _contactService.GetContactListByAccountIdAsync(accountId, cqp);
        return Ok(contacts);
    }

    [HttpGet("{accountId:int}/deals")]
    public async Task<ActionResult<PagedResult<GetDealDto>>> GetDealsByAccountId(int accountId, [FromQuery] DealQueryParameters dqp)
    {
        var deals = await _dealService.GetDealListByAccountIdAsync(accountId, dqp);
        return Ok(deals);
    }
}
