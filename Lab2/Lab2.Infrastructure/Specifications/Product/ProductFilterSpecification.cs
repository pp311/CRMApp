using Lab2.Domain.Enums;
using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.Product;

public class ProductFilterSpecification : Specification<Domain.Entities.Product>
{
    public ProductFilterSpecification(string? search, ProductType? type, ProductSortBy? orderBy, bool isDescending = false)
    {
        // 1. Search by name, description
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField(nameof(Domain.Entities.Product.Name));
            AddSearchField(nameof(Domain.Entities.Product.ProductCode));
        }
        
        // 2. Filter by type
        if (type != null)
            AddFilter(p => p.Type == (int)type);

        // 3. Order by
        if (orderBy == null) return;
        
        AddOrderByField(orderBy.ToString());
        if (isDescending)
            ApplyDescending();
    } 
}