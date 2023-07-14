using System.Linq.Expressions;
using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Contact;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
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

    public async Task<ContactDto> CreateAsync(ContactDto contactDto)
    {
        var contact = _mapper.Map<Contact>(contactDto);
        _contactRepository.Add(contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ContactDto>(contact);
    }

    public async Task<bool> DeleteAsync(int contactId)
    {
        _contactRepository.Delete(new Contact { Id = contactId });
        return await _unitOfWork.CommitAsync() > 0;
    }

    public async Task<ContactDto> GetByIdAsync(int id)
    {
        return _mapper.Map<ContactDto>(await _contactRepository.GetByIdAsync(id));
    }

    public async Task<PagedResult<ContactDto>> GetListAsync(ContactQueryParameters cqp)
    {
        var (contacts, contactCount) = await _contactRepository.GetContactPagedListAsync(cqp);
        var result = _mapper.Map<List<ContactDto>>(contacts);

        return new PagedResult<ContactDto>(result, contactCount, cqp.PageIndex, cqp.PageSize);
    }

    public async Task<ContactDto> UpdateAsync(ContactDto contactDto)
    {
        var contact = await _contactRepository.GetByIdAsync(contactDto.Id);
        _mapper.Map(contactDto, contact);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ContactDto>(contact);
    }
}

