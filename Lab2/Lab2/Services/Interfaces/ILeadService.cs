using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface ILeadService
{
    Task<PagedResult<GetLeadDto>> GetListAsync(LeadQueryParameters lqp);
    Task<GetLeadDto?> GetByIdAsync(int id);
    Task<GetLeadDto> CreateAsync(AddLeadDto leadDto);
    Task<GetLeadDto> UpdateAsync(UpdateLeadDto leadDto);
    Task DeleteAsync(int leadId);
    Task<DealDto> QualifyLeadAsync(int leadId);
    Task<GetLeadDto> DisqualifyLeadAsync(int leadId, DisqualifyLeadDto? disqualifyLeadDto);
    Task<LeadStatisticsDto> GetLeadStatisticsAsync();
}
