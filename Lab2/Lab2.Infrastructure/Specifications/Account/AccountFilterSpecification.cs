using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.Account;

public class AccountFilterSpecification : Specification<Domain.Entities.Account>
{
    public AccountFilterSpecification(string? search, AccountSortBy? orderBy, bool isDescending = false)
    {
        // 1. Search by name, phone, email
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(Domain.Entities.Account.Name));
            AddSearchField(nameof(Domain.Entities.Account.Email));
            AddSearchField(nameof(Domain.Entities.Account.Phone));
        }

        // 2. Order by
        if (orderBy == null) return;
        
        AddOrderByField(orderBy.ToString());
        if (isDescending)
            ApplyDescending();
    }        
}