using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IAccountService
{
    Task<GetAccountDto?> GetByIdAsync(int accountId);
    Task<PagedResult<GetAccountDto>> GetListAsync(AccountQueryParameters accountQueryParameters);
    Task<GetAccountDto> CreateAsync(UpsertAccountDto accountDto);
    Task<GetAccountDto> UpdateAsync(int accountId, UpsertAccountDto accountDto);
    Task DeleteAsync(int accountId);
}
