using Lab2.Application.DTOs.Contact;
using Lab2.Application.DTOs.QueryParameters;

namespace Lab2.Application.Services.Interfaces;

public interface IContactService
{
    Task<GetContactDto?> GetByIdAsync(int id);
    Task<PagedResult<GetContactDto>> GetListAsync(ContactQueryParameters cqp);
    Task<PagedResult<GetContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters contactQueryParameters);
    Task<GetContactDto> CreateAsync(UpsertContactDto upsertContactDto);
    Task<GetContactDto> UpdateAsync(int contactId, UpsertContactDto upsertContactDto);
    Task DeleteAsync(int contactId);
}
