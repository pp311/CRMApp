using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

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
