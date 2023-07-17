using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;
using Lab2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("{contactId:int}")]
    public async Task<ActionResult<ContactDto>> GetContactById(int contactId)
    {
        var contact = await _contactService.GetByIdAsync(contactId);
        if (contact == null)
        {
            return NotFound();
        }
        return Ok(contact);
    }

    [HttpGet]
    public async Task<ActionResult<PagedResult<ContactDto>>> GetContactList([FromQuery] ContactQueryParameters contactQueryParameters)
    {
        var contacts = await _contactService.GetListAsync(contactQueryParameters);
        return Ok(contacts);
    }
    
    [HttpPost]
    public async Task<ActionResult<ContactDto>> CreateContact([FromBody] ContactDto? contactDto)
    {
        if (contactDto == null)
            return BadRequest();
        var createdContact = await _contactService.CreateAsync(contactDto);
        return CreatedAtAction(nameof(GetContactById), new {contactId = createdContact.Id}, createdContact);
    }

    [HttpPut("{contactId:int}")]
    public async Task<ActionResult<ContactDto>> UpdateContact(int contactId, [FromBody] ContactDto? contactDto)
    {
        if (contactDto == null)
            return BadRequest();
        contactDto.Id = contactId;
        
        var updatedContact = await _contactService.UpdateAsync(contactDto);
        return Ok(updatedContact);
    }

    [HttpDelete("{contactId:int}")]
    public async Task<ActionResult> DeleteContact(int contactId)
    {
        await _contactService.DeleteAsync(contactId);
        return NoContent();
    }
}
