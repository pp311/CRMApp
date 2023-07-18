using System.Linq.Expressions;
using Lab2.DomainModels;
using Lab2.DTOs.Lead;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums;

namespace Lab2.Repositories.Interfaces
{
    public interface ILeadRepository : IRepositoryBase<Lead>
    {
        Task<(IEnumerable<Lead> Items, int TotalCount)> GetLeadPagedListAsync(string? search,
                                                                                LeadStatus? status,
                                                                                string? orderBy,
                                                                                int skip,
                                                                                int take,
                                                                                bool isDescending,
                                                                                Expression<Func<Lead, bool>>? condition = null);
        Task<LeadStatistics> GetLeadStatisticsAsync();
    }

}
