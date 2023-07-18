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
    
    private async Task ValidateSavingContact(UpsertContactDto upsertContactDto, int contactId = 0)
    {
        // Phone & email are unique fields so contacts are at most 2 items
        var contacts = await _contactRepository.GetByConditionAsync(c => (c.Phone != null && c.Phone == upsertContactDto.Phone)
                                                                   || (c.Email == upsertContactDto.Email));
        contacts = contacts.ToList();
        
        //  Check phone field uniqueness
        if (!string.IsNullOrEmpty(upsertContactDto.Phone) && contacts.Any(c => c.Phone == upsertContactDto.Phone && c.Id != contactId))
        {
               throw new EntityValidationException("This phone number is already used by another contact"); 
        } 
        
        // Check email field uniqueness
        if (!string.IsNullOrEmpty(upsertContactDto.Email) && contacts.Any(c => c.Email == upsertContactDto.Email && c.Id != contactId))
        {
               throw new EntityValidationException("This email is already used by another contact"); 
        }
    }

    public async Task<GetContactDto> CreateAsync(UpsertContactDto upsertContactDto)
    {
        // Check phone and email uniqueness
        await ValidateSavingContact(upsertContactDto);
        
        // Check if account of the contact is exist
        if (!await _accountRepository.IsExistAsync(a => a.Id == upsertContactDto.AccountId))
            throw new EntityNotFoundException($"Account with id {upsertContactDto.AccountId} not found");
        
        var contact = _mapper.Map<Contact>(upsertContactDto);
        _contactRepository.Add(contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetContactDto>(contact);
    }

    public async Task DeleteAsync(int contactId)
    {
        // Check if contact is exist
        if (!await _contactRepository.IsExistAsync(c => c.Id == contactId))
            throw new EntityNotFoundException($"Contact with id {contactId} is not found");
        
        _contactRepository.Delete(new Contact { Id = contactId });
        await _unitOfWork.CommitAsync();
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

    public async Task<GetContactDto> UpdateAsync(int contactId, UpsertContactDto upsertContactDto)
    {
        var contact = await _contactRepository.GetByIdAsync(contactId);
        if (contact == null)
            throw new EntityNotFoundException($"Contact with id {contactId} is not found");
        
        // Check phone and email uniqueness
        await ValidateSavingContact(upsertContactDto, contactId);
        
        // Check if account of the contact is exist
        if (!await _accountRepository.IsExistAsync(a => a.Id == upsertContactDto.AccountId))
            throw new EntityNotFoundException($"Account with id {upsertContactDto.AccountId} not found");
        
        
        _mapper.Map(upsertContactDto, contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetContactDto>(contact);
    }
}

