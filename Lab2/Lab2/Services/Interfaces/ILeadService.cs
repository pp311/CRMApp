using Lab2.DTOs.Deal;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;

namespace Lab2.Services.Interfaces;

public interface ILeadService
{
    Task<PagedResult<LeadDto>> GetListAsync(LeadQueryParameters lqp);
    Task<LeadDto?> GetByIdAsync(int id);
    Task<LeadDto> CreateAsync(AddLeadDto leadDto);
    Task<LeadDto> UpdateAsync(LeadDto leadDto);
    Task<bool> DeleteAsync(int leadId);
    Task<DealDto> QualififyLeadAsync(int leadId);
    Task<LeadDto> DisqualifyLeadAsync(int leadId, DisqualifyLeadDto? disqualifyLeadDto);
}
