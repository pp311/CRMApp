using Lab2.Application.DTOs.Account;
using Lab2.Application.DTOs.QueryParameters;

namespace Lab2.Application.Interfaces;

public interface IAccountService
{
    Task<GetAccountDto?> GetByIdAsync(int accountId);
    Task<PagedResult<GetAccountDto>> GetListAsync(AccountQueryParameters accountQueryParameters);
    Task<GetAccountDto> CreateAsync(UpsertAccountDto accountDto);
    Task<GetAccountDto> UpdateAsync(int accountId, UpsertAccountDto accountDto);
    Task DeleteAsync(int accountId);
}
