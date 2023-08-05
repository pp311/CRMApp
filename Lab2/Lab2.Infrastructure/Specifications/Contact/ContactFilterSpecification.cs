using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.Contact;

public class ContactFilterSpecification : Specification<Domain.Entities.Contact>
{
    public ContactFilterSpecification(string? search, ContactSortBy? orderBy, bool isDescending = false)
    {
        // 1. Include Account
        AddInclude(c => c.Account!);
        
        // 2. Search by title
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(Domain.Entities.Contact.Name));
            AddSearchField(nameof(Domain.Entities.Contact.Email));
            AddSearchField(nameof(Domain.Entities.Contact.Phone));
        }
        
        // 3. Order by
        if (orderBy == null) return;
        
        AddOrderByField(orderBy.ToString());
        if (isDescending)
            ApplyDescending();
    }        
}
