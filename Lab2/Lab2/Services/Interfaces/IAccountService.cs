using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IAccountService
{
    Task<AccountDto?> GetByIdAsync(int accountId);
    Task<PagedResult<AccountDto>> GetListAsync(AccountQueryParameters accountQueryParameters);
    Task<AccountDto> CreateAsync(AccountDto accountDto);
    Task<AccountDto> UpdateAsync(AccountDto accountDto);
    Task<bool> DeleteAsync(int accountId);
    Task<PagedResult<ContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters contactQueryParameters);
    Task<PagedResult<LeadDto>> GetLeadListByAccountIdAsync(int accountId, LeadQueryParameters leadQueryParameters);
    Task<PagedResult<DealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters dealQueryParameters);
}
