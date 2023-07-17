using System.Linq.Expressions;
using Lab2.DTOs.QueryParameters;
using Lab2.Entities;

namespace Lab2.Repositories.Interfaces
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
        Task<(IEnumerable<Contact> Items, int TotalCount)> GetContactPagedListAsync(string? search,
                                                                                    string? orderBy,
                                                                                    int skip,
                                                                                    int take,
                                                                                    bool isDescending,
                                                                                    Expression<Func<Contact, bool>>? condition = null);
    }
}
