using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Account;
using Lab2.DTOs.Contact;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Exceptions;
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
    
    public async Task<GetAccountDto> CreateAsync(UpsertAccountDto accountDto)
    {
        // Check phone and email uniqueness
        await ValidateSavingAccount(accountDto);
        
        // Create account
        var account = _mapper.Map<Account>(accountDto);
        _accountRepository.Add(account);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetAccountDto>(account);
    }

    public async Task DeleteAsync(int accountId)
    {
        // Check if account exists
        if (!await _accountRepository.IsAccountExistAsync(accountId))
            throw new EntityNotFoundException($"Account with id {accountId} does not exist");
        
        _accountRepository.Delete(new Account { Id = accountId });
        await _unitOfWork.CommitAsync();
    }
    
    public async Task<GetAccountDto> UpdateAsync(int accountId, UpsertAccountDto accountDto)
    {
        await ValidateSavingAccount(accountDto, accountId);
        
        var account = await _accountRepository.GetByIdAsync(accountId)
            ?? throw new EntityNotFoundException($"Account with id {accountId} not found");
        
        _mapper.Map(accountDto, account);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetAccountDto>(account);
    }

    public async Task<GetAccountDto?> GetByIdAsync(int accountId)
    {
        return _mapper.Map<GetAccountDto>(await _accountRepository.GetByIdAsync(accountId));
    }

    public async Task<PagedResult<GetAccountDto>> GetListAsync(AccountQueryParameters aqp)
    {
        var (accounts, accountCount) = await _accountRepository.GetAccountPagedListAsync(search: aqp.Search,
                                                                                         orderBy: aqp.OrderBy,
                                                                                         skip: (aqp.PageIndex - 1) * aqp.PageSize,
                                                                                         take: aqp.PageSize,
                                                                                         isDescending: aqp.IsDescending);
        
        var result = _mapper.Map<List<GetAccountDto>>(accounts);

        return new PagedResult<GetAccountDto>(result, accountCount, aqp.PageIndex, aqp.PageSize);
    }

    public async Task<PagedResult<GetContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(search: cqp.Search,
                                                                                         orderBy: cqp.OrderBy,
                                                                                         skip: (cqp.PageIndex - 1) * cqp.PageSize,
                                                                                         take: cqp.PageSize,
                                                                                         isDescending: cqp.IsDescending,
                                                                                         condition: c => c.AccountId == accountId);
        var result = _mapper.Map<List<GetContactDto>>(contacts);

        return new PagedResult<GetContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }

    public async Task<PagedResult<GetLeadDto>> GetLeadListByAccountIdAsync(int accountId, LeadQueryParameters lqp)
    {
        var (leads, leadCount) = await _leadRepository.GetLeadPagedListAsync(search: lqp.Search,
                                                                             status: lqp.Status,
                                                                             orderBy: lqp.OrderBy,
                                                                             skip: (lqp.PageIndex - 1) * lqp.PageSize,
                                                                             take: lqp.PageSize,
                                                                             isDescending: lqp.IsDescending,
                                                                             condition: l => l.AccountId == accountId);
        var result = _mapper.Map<List<GetLeadDto>>(leads);

        return new PagedResult<GetLeadDto>(result, leadCount, lqp.PageIndex, lqp.PageSize);
    }

    public async Task<PagedResult<GetDealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters dqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(search: dqp.Search,
                                                                             status: dqp.Status,
                                                                             orderBy: dqp.OrderBy,
                                                                             skip: (dqp.PageIndex - 1) * dqp.PageSize,
                                                                             take: dqp.PageSize,
                                                                             isDescending: dqp.IsDescending,
                                                                             condition: d => d.Lead!.AccountId == accountId);
        var result = _mapper.Map<List<GetDealDto>>(deals);

        return new PagedResult<GetDealDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }
    
    // Account validation methods 
    private async Task ValidateSavingAccount(UpsertAccountDto accountDto, int accountId = 0)
    {
        //  Check phone field uniqueness
        if (!string.IsNullOrEmpty(accountDto.Email) && await _accountRepository.IsEmailDuplicatedAsync(accountDto.Email, accountId))
            throw new EntityValidationException("This email is already used by another account"); 
        
        // Check email field uniqueness
        if (!string.IsNullOrEmpty(accountDto.Phone) && await _accountRepository.IsPhoneDuplicatedAsync(accountDto.Phone, accountId))
            throw new EntityValidationException("This phone number is already used by another account"); 
    }
}
