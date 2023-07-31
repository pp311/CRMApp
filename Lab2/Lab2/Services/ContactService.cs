using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ContactService(IContactRepository contactRepository, 
                          IAccountRepository accountRepository, 
                          IMapper mapper, 
                          IUnitOfWork unitOfWork)
    {
        _contactRepository = contactRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<GetContactDto> CreateAsync(UpsertContactDto upsertContactDto)
    {
        await ValidateCreatingContact(upsertContactDto);
        
        var contact = _mapper.Map<Contact>(upsertContactDto);
        _contactRepository.Add(contact);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetContactDto>(contact);
    }

    public async Task DeleteAsync(int contactId)
    {
        // Check if contact is exist
        if (!await _contactRepository.IsContactExistAsync(contactId))
            throw new EntityNotFoundException($"Contact with id {contactId} is not found");
        
        _contactRepository.Delete(new Contact { Id = contactId });
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<GetContactDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<GetContactDto>(await _contactRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<GetContactDto>> GetListAsync(ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(search: cqp.Search,
                                                                                         orderBy: cqp.OrderBy,
                                                                                         skip: (cqp.PageIndex - 1) * cqp.PageSize,
                                                                                         take: cqp.PageSize,
                                                                                         isDescending: cqp.IsDescending);
        var result = _mapper.Map<List<GetContactDto>>(contacts);

        return new PagedResult<GetContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }
    
    public async Task<PagedResult<GetContactDto>> GetContactListByAccountIdAsync(int accountId, ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(search: cqp.Search,
                                                                                         orderBy: cqp.OrderBy,
                                                                                         skip: (cqp.PageIndex - 1) * cqp.PageSize,
                                                                                         take: cqp.PageSize,
                                                                                         isDescending: cqp.IsDescending,
                                                                                         accountId: accountId);
        var result = _mapper.Map<List<GetContactDto>>(contacts);

        return new PagedResult<GetContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }

    public async Task<GetContactDto> UpdateAsync(int contactId, UpsertContactDto upsertContactDto)
    {
        var validatedContact = await ValidateUpdatingContact(upsertContactDto, contactId);
        
        _mapper.Map(upsertContactDto, validatedContact);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<GetContactDto>(validatedContact);
    }
    
    // Contact validation methods 
    private async Task ValidateCreatingContact(UpsertContactDto contactDto)
    {
        if (!string.IsNullOrEmpty(contactDto.Phone) && await _contactRepository.IsPhoneDuplicatedAsync(contactDto.Phone))
            throw new EntityValidationException("This phone number is already used by another contact"); 
        
        if (!string.IsNullOrEmpty(contactDto.Email) && await _contactRepository.IsEmailDuplicatedAsync(contactDto.Email))
            throw new EntityValidationException("This email is already used by another contact"); 
        
        if (!await _accountRepository.IsAccountExistAsync(contactDto.AccountId))
            throw new EntityNotFoundException($"Account with id {contactDto.AccountId} not found");
    }

    private async Task<Contact> ValidateUpdatingContact(UpsertContactDto contactDto, int contactId)
    {
        var contact = await _contactRepository.GetByIdAsync(contactId) 
                      ?? throw new EntityNotFoundException($"Contact with id {contactId} is not found");
        
        // Check phone uniqueness
        if (!string.IsNullOrEmpty(contactDto.Phone) && await _contactRepository.IsPhoneDuplicatedAsync(contactDto.Phone, contactId))
            throw new EntityValidationException("This phone number is already used by another contact"); 
        
        // Check email uniqueness
        if (!string.IsNullOrEmpty(contactDto.Email) && await _contactRepository.IsEmailDuplicatedAsync(contactDto.Email, contactId))
            throw new EntityValidationException("This email is already used by another contact"); 
        
        // Check if account of the contact is exist when updating account id
        if (contactDto.AccountId != contact.AccountId && !await _accountRepository.IsAccountExistAsync(contactDto.AccountId))
            throw new EntityNotFoundException($"Account with id {contactDto.AccountId} not found");
        
        return contact;
    }
}

