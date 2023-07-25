using Lab2.Constant;
using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
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
        if (contact == null)
        {
            return NotFound();
        }
        return Ok(contact);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<GetContactDto>>> GetContactList([FromQuery] ContactQueryParameters contactQueryParameters)
    {
        var contacts = await _contactService.GetListAsync(contactQueryParameters);
        return Ok(contacts);
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
        
        if (await _contactService.GetByIdAsync(contactId) == null)
            return NotFound();
        
        var updatedContact = await _contactService.UpdateAsync(contactId, contactDto);
        return Ok(updatedContact);
    }

    [HttpDelete("{contactId:int}")]
    [Authorize(Policy = AuthPolicy.AdminOnly)]
    public async Task<ActionResult> DeleteContact(int contactId)
    {
        if (await _contactService.GetByIdAsync(contactId) == null)
            return NotFound();
        
        await _contactService.DeleteAsync(contactId);
        return NoContent();
    }
}
