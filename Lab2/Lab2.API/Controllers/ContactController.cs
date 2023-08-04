using Lab2.Application.DTOs.Contact;
using Lab2.Application.DTOs.QueryParameters;
using Lab2.Application.Interfaces;
using Lab2.Domain.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Authorize]
[Route("api/contacts")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("{contactId:int}")]
    public async Task<ActionResult<GetContactDto>> GetContactById(int contactId)
    {
        var contact = await _contactService.GetByIdAsync(contactId);
        return contact == null ? NotFound() : Ok(contact);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetContactDto>>> GetContactList([FromQuery] ContactQueryParameters contactQueryParameters)
    {
        var contacts = await _contactService.GetListAsync(contactQueryParameters);
        return Ok(contacts);
    }
    
    [HttpGet("account/{accountId:int}")]
    public async Task<ActionResult<PagedResult<UpsertContactDto>>> GetContactList(int accountId, [FromQuery] ContactQueryParameters cqp)
    {
        return Ok(await _contactService.GetContactListByAccountIdAsync(accountId, cqp));
    }
    
    [HttpPost]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetContactDto>> CreateContact([FromBody] UpsertContactDto? contactDto)
    {
        if (contactDto == null)
            return BadRequest();
        var createdContact = await _contactService.CreateAsync(contactDto);
        return CreatedAtAction(nameof(GetContactById), new {contactId = createdContact.Id}, createdContact);
    }

    [HttpPut("{contactId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult<GetContactDto>> UpdateContact(int contactId, [FromBody] UpsertContactDto? contactDto)
    {
        if (contactDto == null)
            return BadRequest();
        
        var updatedContact = await _contactService.UpdateAsync(contactId, contactDto);
        return Ok(updatedContact);
    }

    [HttpDelete("{contactId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult> DeleteContact(int contactId)
    {
        await _contactService.DeleteAsync(contactId);
        return NoContent();
    }
}
