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
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ContactService(IContactRepository contactRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    private async Task ValidateSavingContact(ContactDto contactDto)
    {
        // For update operation, check if any other account with this phone or email exists
        // For add operation, dto id will be 0, so we can also use this method
        
        //  Check phone field uniqueness if it modified and not empty
        if (!string.IsNullOrEmpty(contactDto.Phone))
        {
           if (!await _contactRepository.IsExistAsync(a => a.Phone == contactDto.Phone 
                                                           && a.Id != contactDto.Id))
               throw new EntityValidationException("This phone number is already taken"); 
        } 
        
        // Check email field uniqueness if it modified and not empty
        if (!string.IsNullOrEmpty(contactDto.Email))
        {
           if (!await _contactRepository.IsExistAsync(a => a.Email == contactDto.Email 
                                                           && a.Id != contactDto.Id))
               throw new EntityValidationException("This email is already taken"); 
        }
    }

    public async Task<ContactDto> CreateAsync(ContactDto contactDto)
    {
        // Check phone and email uniqueness
        await ValidateSavingContact(contactDto);
        
        var contact = _mapper.Map<Contact>(contactDto);
        _contactRepository.Add(contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ContactDto>(contact);
    }

    public async Task DeleteAsync(int contactId)
    {
        // Check if contact is exist
        if (!await _contactRepository.IsExistAsync(c => c.Id == contactId))
            throw new EntityNotFoundException($"Contact with id {contactId} is not found");
        
        _contactRepository.Delete(new Contact { Id = contactId });
        await _unitOfWork.CommitAsync();
    }

    public async Task<ContactDto?> GetByIdAsync(int id)
    {
        return _mapper.Map<ContactDto>(await _contactRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<ContactDto>> GetListAsync(ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(search: cqp.Search,
                                                                                         orderBy: cqp.OrderBy,
                                                                                         skip: (cqp.PageIndex - 1) * cqp.PageSize,
                                                                                         take: cqp.PageSize,
                                                                                         isDescending: cqp.IsDescending);
        var result = _mapper.Map<List<ContactDto>>(contacts);

        return new PagedResult<ContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }

    public async Task<ContactDto> UpdateAsync(ContactDto contactDto)
    {
        // Check phone and email uniqueness
        await ValidateSavingContact(contactDto);
        
        var contact = await _contactRepository.GetByIdAsync(contactDto.Id);
        if (contact == null)
            throw new EntityNotFoundException($"Contact with id {contactDto.Id} is not found");
        
        _mapper.Map(contactDto, contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ContactDto>(contact);
    }
}

