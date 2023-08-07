using Lab2.Domain.DomainModels;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Domain.Repositories
{
    public interface ILeadRepository : IRepositoryBase<Lead>
    {
        Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(string? search,
                                                                                LeadStatus? status,
                                                                                LeadSortBy? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending);
        Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(int accountId,
                                                                              string? search,
                                                                              LeadStatus? status,
                                                                              LeadSortBy? orderBy,
                                                                              int skip,
                                                                              int take,
                                                                              bool isDescending);
        
        Task<LeadStatisticsModel> GetLeadStatisticsAsync();
        Task<bool> IsLeadExistAsync(int leadId);
    }

}
