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

    [HttpPut("{contactId:int}")]
    public async Task<ActionResult<ContactDto>> UpdateContact(int contactId, [FromBody] ContactDto? contactDto)
    {
        // 1. Check:
        // - if dto provided
        // - if dto id is provided and equal to path parameter
        if ((contactDto == null) || (contactDto.Id != default && contactDto.Id != contactId))
            return BadRequest();
        // 2. If dto id is not provided, set it
        contactDto.Id = contactId;
        // 3. Update contact
        var updatedContact = await _contactService.UpdateAsync(contactDto);
        return Ok(updatedContact);
    }

    [HttpDelete("{contactId:int}")]
    public async Task<ActionResult> DeleteContact(int contactId)
    {
        if (await _contactService.DeleteAsync(contactId))
        {
            return NoContent();
        }
        return NotFound();
    }
}
