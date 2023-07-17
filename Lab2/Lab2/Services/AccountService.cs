using System.Linq.Expressions;
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
    
    private async Task ValidateSavingAccount(AccountDto accountDto)
    {
        // For update operation, check if any other account with this phone or email exists
        // For add operation, dto id will be 0, so we can also use this method
        
        //  Check phone field uniqueness if it modified and not empty
        if (!string.IsNullOrEmpty(accountDto.Phone))
        {
           if (!await _accountRepository.IsExistAsync(a => a.Phone == accountDto.Phone 
                                                           && a.Id != accountDto.Id))
               throw new EntityValidationException("This phone number is already taken"); 
        } 
        
        // Check email field uniqueness if it modified and not empty
        if (!string.IsNullOrEmpty(accountDto.Email))
        {
           if (!await _accountRepository.IsExistAsync(a => a.Email == accountDto.Email 
                                                           && a.Id != accountDto.Id))
               throw new EntityValidationException("This email is already taken"); 
        }
    }

    public async Task<AccountDto> CreateAsync(AccountDto accountDto)
    {
        // Check phone and email uniqueness
        await ValidateSavingAccount(accountDto);
        
        // Create account
        var account = _mapper.Map<Account>(accountDto);
        _accountRepository.Add(account);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<AccountDto>(account);
    }

    public async Task DeleteAsync(int accountId)
    {
        // Check if account exists
        if (!await _accountRepository.IsExistAsync(a => a.Id == accountId))
            throw new EntityNotFoundException($"Account with id {accountId} does not exist");
        
        _accountRepository.Delete(new Account { Id = accountId });
        await _unitOfWork.CommitAsync();
    }
    
    public async Task<AccountDto> UpdateAsync(AccountDto accountDto)
    {
        // 1. Get account from database
        var account = await _accountRepository.GetByIdAsync(accountDto.Id);
        if (account == null)
            throw new EntityNotFoundException($"Account with id {accountDto.Id} not found");
        
        // 2. Check phone field uniqueness if it modified and not empty
        // 3. Check email field uniqueness if it modified and not empty
        await ValidateSavingAccount(accountDto);
        
        // 4. Update account
        _mapper.Map(accountDto, account);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<AccountDto>(account);
    }

    public async Task<AccountDto?> GetByIdAsync(int accountId)
    {
        return _mapper.Map<AccountDto>(await _accountRepository.GetByIdAsync(accountId));
    }

    public async Task<PagedResult<AccountDto>> GetListAsync(AccountQueryParameters aqp)
    {
        // Expression for search by name field
        Expression<Func<Account, bool>>? expression = string.IsNullOrEmpty(aqp.Search)
            ? a => a.Name.ToLower().Contains(aqp.Search.Trim().ToLower())
            : null;

        var (accounts, accountCount) = await _accountRepository.GetPagedListAsync(expression,
                                                                                  orderBy: aqp.OrderBy,
                                                                                  skip: (aqp.PageIndex - 1) * aqp.PageSize,
                                                                                  take: aqp.PageSize,
                                                                                  isDescending: aqp.IsDescending);
        
        var result = _mapper.Map<List<AccountDto>>(accounts);

        return new PagedResult<AccountDto>(result, accountCount, aqp.PageIndex, aqp.PageSize);
    }

    public async Task<PagedResult<ContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(search: cqp.Search,
                                                                                         orderBy: cqp.OrderBy,
                                                                                         skip: (cqp.PageIndex - 1) * cqp.PageSize,
                                                                                         take: cqp.PageSize,
                                                                                         isDescending: cqp.IsDescending,
                                                                                         condition: c => c.AccountId == accountId);
        var result = _mapper.Map<List<ContactDto>>(contacts);

        return new PagedResult<ContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
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

    public async Task<PagedResult<DealDto>> GetDealListByAccountIdAsync(int accountId, DealQueryParameters dqp)
    {
        var (deals, dealCount) = await _dealRepository.GetDealPagedListAsync(search: dqp.Search,
                                                                             status: dqp.Status,
                                                                             orderBy: dqp.OrderBy,
                                                                             skip: (dqp.PageIndex - 1) * dqp.PageSize,
                                                                             take: dqp.PageSize,
                                                                             isDescending: dqp.IsDescending,
                                                                             condition: d => d.Lead!.AccountId == accountId);
        var result = _mapper.Map<List<DealDto>>(deals);

        return new PagedResult<DealDto>(result, dealCount, dqp.PageIndex, dqp.PageSize);
    }
}
