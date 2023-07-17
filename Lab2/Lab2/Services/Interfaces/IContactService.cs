using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IContactService
{
    Task<ContactDto?> GetByIdAsync(int id);
    Task<PagedResult<ContactDto>> GetListAsync(ContactQueryParameters cqp);
    Task<ContactDto> CreateAsync(ContactDto contactDto);
    Task<ContactDto> UpdateAsync(ContactDto contactDto);
    Task DeleteAsync(int contactId);
}
