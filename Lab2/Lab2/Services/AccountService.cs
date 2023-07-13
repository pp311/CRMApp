using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Account;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AccountService(IAccountRepository accountRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AccountDto> CreateAsync(AccountDto accountDto)
    {
        var account = _mapper.Map<Account>(accountDto);
        _accountRepository.Add(account);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<AccountDto>(account);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _accountRepository.Delete(new Account { Id = id });
        return await _unitOfWork.CommitAsync() > 0;
    }

    public async Task<AccountDto?> GetByIdAsync(int accountId)
    {
        return _mapper.Map<AccountDto>(await _accountRepository.GetByIdAsync(accountId));
    }

    public async Task<PagedResult<AccountDto>> GetListAsync(AccountQueryParameters aqp)
    {
        int skip = (aqp.PageIndex - 1) * aqp.PageSize;
        int take = aqp.PageSize;
        var accounts = await _accountRepository.GetListAsync(null, aqp.OrderBy, skip, take, aqp.IsDescending);
        var accountCount = await _accountRepository.CountAsync();
        var result = _mapper.Map<List<AccountDto>>(accounts);

        return new PagedResult<AccountDto>(result, accountCount, aqp.PageIndex, aqp.PageSize);
    }

    public async Task<AccountDto> UpdateAsync(AccountDto accountDto)
    {
        var account = _mapper.Map<Account>(accountDto);
        _accountRepository.Update(account);
        await _unitOfWork.CommitAsync();
        return accountDto;
    }
}
