using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;
using Lab2.Enums.Sorting;

namespace Lab2.Repositories.Interfaces
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
        Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(string? search,
                                                                                    ContactSortBy? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    int? accountId = null);
        Task<bool> IsEmailDuplicatedAsync(string email, int contactId = 0);
        Task<bool> IsPhoneDuplicatedAsync(string phone, int contactId = 0);
        Task<bool> IsContactExistAsync(int contactId);
    }
}
