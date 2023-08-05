using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.Lead;

public class LeadFilterSpecification : Specification<Domain.Entities.Lead>
{
    public LeadFilterSpecification(string? search, LeadStatus? status, LeadSortBy? orderBy, bool isDescending = false)
    {
        // 1. Include Account
        AddInclude(l => l.Account!);
        
        // 2. Search by title
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(Domain.Entities.Lead.Title));
        }
        
        // 3. Filter by status
        if (status != null)
            AddFilter(l => l.Status == (int)status);
        
        // 4. Order by
        if (orderBy == null) return;
        
        var sortingField = orderBy == LeadSortBy.AccountName ? "Account.Name" : orderBy.ToString();
        
        AddOrderByField(sortingField);
        if (isDescending)
            ApplyDescending();
    }        
}