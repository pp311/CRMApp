using AutoMapper;
using Lab2.Data;
using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Exceptions;
using Lab2.Repositories.Interfaces;
using Lab2.Services.Interfaces;

namespace Lab2.Services;

public class LeadService : ILeadService
{
    private readonly ILeadRepository _leadRepository;
    private readonly IDealRepository _dealRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public LeadService(ILeadRepository leadRepository,
                       IDealRepository dealRepository,
                       IMapper mapper,
                       IUnitOfWork unitOfWork)
    {
        _leadRepository = leadRepository;
        _dealRepository = dealRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<LeadDto> CreateAsync(AddLeadDto leadDto)
    {
        var lead = _mapper.Map<Lead>(leadDto);
        lead.Status = (int)LeadStatus.Prospect;
        _leadRepository.Add(lead);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<LeadDto>(lead);
    }

    public async Task<bool> DeleteAsync(int leadId)
    {
        _leadRepository.Delete(new Lead { Id = leadId });
        return await _unitOfWork.CommitAsync() > 0;
    }

    public async Task<LeadDto> DisqualifyLeadAsync(int leadId, DisqualifyLeadDto? disqualifyLeadDto)
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadId);
        // 2. If lead is already ended (qualified or disqualified), throw exception
        if (lead!.Status == (int)LeadStatus.Qualified || lead.Status == (int)LeadStatus.Disqualified)
        {
            throw new InvalidUpdateException("Lead is already ended");
        }
        // 3. If lead is not ended, update lead status and end date
        lead.Status = (int)LeadStatus.Disqualified;
        lead.EndedDate = DateTime.Now;
        // 4. If disqualifyLeadDto is provided, update lead reason
        if (disqualifyLeadDto != null)
        {
            lead.DisqualifiedReason = (int)disqualifyLeadDto.DisqualifiedReason;
            lead.DisqualifiedDescription = disqualifyLeadDto.DisqualifiedDescription;
        }
        // 5. Save changes to database, if no changes were made, return false
        await _unitOfWork.CommitAsync();
        // 6, Return updated lead
        return _mapper.Map<LeadDto>(lead);
    }

    public async Task<LeadDto?> GetByIdAsync(int id)
    {
        var lead = await _leadRepository.GetByIdAsync(id);
        return _mapper.Map<LeadDto>(lead);
    }

    public async Task<PagedResult<LeadDto>> GetListAsync(LeadQueryParameters lqp)
    {
        var (leads, leadCount) = await _leadRepository.GetLeadPagedListAsync(lqp);
        var result = _mapper.Map<List<LeadDto>>(leads);

        return new PagedResult<LeadDto>(result, leadCount, lqp.PageIndex, lqp.PageSize);
    }

    public async Task<DealDto> QualififyLeadAsync(int leadId)
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadId);
        // 2. If lead is already ended (qualified or disqualified), throw exception
        if (lead!.Status == (int)LeadStatus.Qualified || lead.Status == (int)LeadStatus.Disqualified)
        {
            throw new InvalidUpdateException("Cannot update ended (qualified or disqualified) lead");
        }
        // 3. Change lead status to qualified and set lead end date
        lead.Status = (int)LeadStatus.Qualified;
        lead.EndedDate = DateTime.Now;
        // 4. Create deal with lead's tittle, deal's status set to Open
        var deal = new Deal
        {
            Title = lead.Title,
            Status = (int)DealStatus.Open,
            LeadId = lead.Id
        };
        _dealRepository.Add(deal);
        await _unitOfWork.CommitAsync();
        // 5. Return deal
        return _mapper.Map<DealDto>(deal);
    }

    public async Task<LeadDto> UpdateAsync(LeadDto leadDto)
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadDto.Id);
        // 2. If lead is already ended (qualified or disqualified), throw exception
        if (lead.Status == (int)LeadStatus.Qualified || lead.Status == (int)LeadStatus.Disqualified)
        {
            throw new InvalidUpdateException("Cannot update ended (qualified or disqualified) lead");
        }
        // 3. Check leadDto: if status is not disqualified, reason must be null
        if (leadDto.Status != LeadStatus.Disqualified && leadDto.DisqualifiedReason != null)
        {
            throw new InvalidUpdateException("Disqualification reason must be null if status is not disqualified");
        }
        // 4. Update Lead
        _mapper.Map(leadDto, lead);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<LeadDto>(lead);
    }
}
