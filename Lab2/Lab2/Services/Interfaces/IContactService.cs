using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IContactService
{
    Task<GetContactDto?> GetByIdAsync(int id);
    Task<PagedResult<GetContactDto>> GetListAsync(ContactQueryParameters cqp);
    Task<GetContactDto> CreateAsync(UpsertContactDto upsertContactDto);
    Task<GetContactDto> UpdateAsync(int contactId, UpsertContactDto upsertContactDto);
    Task DeleteAsync(int contactId);
}
