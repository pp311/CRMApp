using Lab2.Application.DTOs.Deal;
using Lab2.Application.DTOs.Lead;
using Lab2.Application.DTOs.QueryParameters;

namespace Lab2.Application.Interfaces;

public interface ILeadService
{
    Task<PagedResult<GetLeadDto>> GetListAsync(LeadQueryParameters lqp);
    Task<PagedResult<GetLeadDto>> GetLeadListByAccountIdAsync(int accountId, LeadQueryParameters leadQueryParameters);
    Task<GetLeadDto?> GetByIdAsync(int id);
    Task<GetLeadDto> CreateAsync(AddLeadDto leadDto);
    Task<GetLeadDto> UpdateAsync(int leadId, UpdateLeadDto leadDto);
    Task DeleteAsync(int leadId);
    Task<GetDealDto> QualifyLeadAsync(int leadId);
    Task<GetLeadDto> DisqualifyLeadAsync(int leadId, DisqualifyLeadDto? disqualifyLeadDto);
    Task<LeadStatisticsDto> GetLeadStatisticsAsync();
}
