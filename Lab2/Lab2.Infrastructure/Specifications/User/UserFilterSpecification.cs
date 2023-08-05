using Lab2.Domain.Enums.Sorting;
using Lab2.Infrastructure.Identity;

namespace Lab2.Infrastructure.Specifications.User;

public class UserFilterSpecification : Specification<ApplicationUser>
{
    public UserFilterSpecification(string? search, UserSortBy? orderBy, bool isDescending = false)
    {
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(ApplicationUser.Name));
            AddSearchField(nameof(ApplicationUser.Email));
        }        
        
        if (orderBy == null) return;
        
        AddOrderByField(orderBy.ToString());
        if (isDescending)
            ApplyDescending();
    }
}