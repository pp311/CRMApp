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

    public async Task<GetLeadDto> CreateAsync(AddLeadDto leadDto)
    {
        // 1. Check if account exists
        if (!await _dealRepository.IsExistAsync(d => d.Id == leadDto.AccountId))
            throw new EntityNotFoundException($"Account with id {leadDto.AccountId} not found");
        
        // 2. Create lead
        var lead = _mapper.Map<Lead>(leadDto);
        lead.Status = (int)LeadStatus.Prospect;
        _leadRepository.Add(lead);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetLeadDto>(lead);
    }

    public async Task DeleteAsync(int leadId)
    {
        // 1. Check if lead exists
        if (!await _leadRepository.IsExistAsync(l => l.Id == leadId))
            throw new EntityNotFoundException($"Lead with id {leadId} not found");
        
        _leadRepository.Delete(new Lead { Id = leadId });
        await _unitOfWork.CommitAsync();
    }
    
    public async Task<GetLeadDto> UpdateAsync(int leadId, UpdateLeadDto leadDto) 
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadId);
        if (lead == null)
            throw new EntityNotFoundException($"Lead with id {leadId} not found");
        
        // 2. Check leadDto: if status is not disqualified, reason must be null
        if (leadDto.Status != LeadStatus.Disqualified && leadDto.DisqualifiedReason != null)
            throw new InvalidUpdateException("Disqualification reason must be null if status is not disqualified");
        
        // 3. If account is changed, check if new account exists
        if (lead.AccountId != leadDto.AccountId)
        {
            if (!await _dealRepository.IsExistAsync(d => d.Id == leadDto.AccountId))
                throw new EntityNotFoundException($"Account with id {leadDto.AccountId} not found");
        }
        
        // 4. If lead is already ended (qualified or disqualified), only changes in source and desc fields are allowed
        if (lead.Status is (int)LeadStatus.Qualified or (int)LeadStatus.Disqualified)
        {
            lead.Source = (int?)leadDto.Source; 
            lead.Description = leadDto.Description;
        }
        else
        {
            _mapper.Map(leadDto, lead);
        }
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetLeadDto>(lead);
    }
    
    public async Task<LeadStatisticsDto> GetLeadStatisticsAsync()
    {
        var leadStatistics = await _leadRepository.GetLeadStatisticsAsync();
        leadStatistics.AverageEstimatedRevenue = Math.Round(leadStatistics.AverageEstimatedRevenue, 2);
        return await _leadRepository.GetLeadStatisticsAsync();
    }

    public async Task<GetLeadDto?> GetByIdAsync(int id)
    {
        var lead = await _leadRepository.GetByIdAsync(id);
        return _mapper.Map<GetLeadDto>(lead);
    }

    public async Task<PagedResult<GetLeadDto>> GetListAsync(LeadQueryParameters lqp)
    {
        var (leads, leadCount) = await _leadRepository.GetLeadPagedListAsync(search: lqp.Search,
                                                                             status: lqp.Status,
                                                                             orderBy: lqp.OrderBy,
                                                                             skip: (lqp.PageIndex - 1) * lqp.PageSize,
                                                                             take: lqp.PageSize,
                                                                             isDescending: lqp.IsDescending);
        var result = _mapper.Map<List<GetLeadDto>>(leads);

        return new PagedResult<GetLeadDto>(result, leadCount, lqp.PageIndex, lqp.PageSize);
    }

    public async Task<GetLeadDto> DisqualifyLeadAsync(int leadId, DisqualifyLeadDto? disqualifyLeadDto)
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadId);
        
        // 2. If lead is already ended (qualified or disqualified), throw exception
        if (lead!.Status == (int)LeadStatus.Qualified || lead.Status == (int)LeadStatus.Disqualified)
            throw new InvalidUpdateException("Lead is already ended");
        
        // 3. If lead is not ended, update lead status and end date
        lead.Status = (int)LeadStatus.Disqualified;
        lead.EndedDate = DateTime.Now;
        
        // 4. If disqualifyLeadDto is provided, update lead reason
        if (disqualifyLeadDto != null)
        {
            lead.DisqualifiedReason = (int)disqualifyLeadDto.DisqualifiedReason;
            lead.DisqualifiedDescription = disqualifyLeadDto.DisqualifiedDescription;
        }
        
        await _unitOfWork.CommitAsync();
        return _mapper.Map<GetLeadDto>(lead);
    }

    public async Task<GetDealDto> QualifyLeadAsync(int leadId)
    {
        // 1. Get lead from database
        var lead = await _leadRepository.GetByIdAsync(leadId);
        
        // 2. If lead is already ended (qualified or disqualified), throw exception
        if (lead!.Status == (int)LeadStatus.Qualified || lead.Status == (int)LeadStatus.Disqualified)
            throw new InvalidUpdateException("Cannot update ended (qualified or disqualified) lead");
        
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
        return _mapper.Map<GetDealDto>(deal);
    }

}
