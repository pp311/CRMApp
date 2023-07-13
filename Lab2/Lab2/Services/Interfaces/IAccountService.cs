using Lab2.DTOs.Account;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface IAccountService
{
    Task<AccountDto?> GetByIdAsync(int accountId);
    Task<PagedResult<AccountDto>> GetListAsync(AccountQueryParameters accountQueryParameters);
    Task<AccountDto> CreateAsync(AccountDto accountDto);
    Task<AccountDto> UpdateAsync(AccountDto accountDto);
    Task<bool> DeleteAsync(int accountId);
}
