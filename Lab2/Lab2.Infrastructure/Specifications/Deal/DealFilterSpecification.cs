using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.Deal;

public class DealFilterSpecification : Specification<Domain.Entities.Deal>
{
    public DealFilterSpecification(string? search, DealStatus? status, DealSortBy? orderBy, bool isDescending = false)
    {
        // 1. Search by name, phone, email
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(Domain.Entities.Deal.Title));
        }
        
        // 2. Filter by status
        if (status != null)
            AddFilter(p => p.Status == (int)status);

        // 3. Order by
        if (orderBy == null) return;
        
        AddOrderByField(orderBy.ToString());
        if (isDescending)
            ApplyDescending();
    }
}