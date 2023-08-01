using Lab2.DomainModels;
using Lab2.Entities;
using Lab2.Enums;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces
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
        
        Task<LeadStatistics> GetLeadStatisticsAsync();
        Task<bool> IsLeadExistAsync(int leadId);
    }

}
