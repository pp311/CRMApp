using System.Linq.Expressions;
using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly ILeadRepository _leadRepository;
    private readonly IContactRepository _contactRepository;
    private readonly IDealRepository _dealRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AccountService(IAccountRepository accountRepository,
                          ILeadRepository leadRepository,
                          IContactRepository contactRepository,
                          IDealRepository dealRepository,
                          IUnitOfWork unitOfWork,
                          IMapper mapper)
    {
        _accountRepository = accountRepository;
        _leadRepository = leadRepository;
        _contactRepository = contactRepository;
        _dealRepository = dealRepository;
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
        Expression<Func<Account, bool>>? expression = aqp.Search != null ? a => a.Name.ToLower().Contains(aqp.Search.Trim().ToLower()) : null;
        var (accounts, accountCount) = await _accountRepository.GetPagedListAsync(expression, aqp.OrderBy, skip, take, aqp.IsDescending);
        var result = _mapper.Map<List<AccountDto>>(accounts);

        return new PagedResult<AccountDto>(result, accountCount, aqp.PageIndex, aqp.PageSize);
    }

    public async Task<AccountDto> UpdateAsync(AccountDto accountDto)
    {
        // 1. Get account from database
        var account = await _accountRepository.GetByIdAsync(accountDto.Id);
        // 2. Update account
        _mapper.Map(accountDto, account);
        await _unitOfWork.CommitAsync();
        return accountDto;
    }

    public async Task<PagedResult<ContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters cqp)
    {
        var contacts = await _contactRepository.GetContactPagedListAsync(cqp, c => c.AccountId == accountId);
        var contactCount = await _contactRepository.CountAsync(c => c.AccountId == accountId);
        var result = _mapper.Map<List<ContactDto>>(contacts);

        return new PagedResult<ContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }

    public async Task<PagedResult<LeadDto>> GetLeadListByAccountIdAsync(int accountId, LeadQueryParameters lqp)
    {
        var leads = await _leadRepository.GetLeadPagedListAsync(lqp, l => l.AccountId == accountId);
        var leadCount = await _leadRepository.CountAsync(l => l.AccountId == accountId);
        var result = _mapper.Map<List<LeadDto>>(leads);

        return new PagedResult<LeadDto>(result, leadCount, lqp.PageIndex, lqp.PageSize);
    }

    public async Task<PagedResult<DealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters lqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(lqp, d => d.Lead!.AccountId == accountId);
        var result = _mapper.Map<List<DealDto>>(deals);

        return new PagedResult<DealDto>(result, dealCount, lqp.PageIndex, lqp.PageSize);
    }
}
