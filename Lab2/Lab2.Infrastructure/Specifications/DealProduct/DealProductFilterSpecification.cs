using Lab2.Domain.Enums.Sorting;

namespace Lab2.Infrastructure.Specifications.DealProduct;

public class DealProductFilterSpecification : Specification<Domain.Entities.DealProduct>
{
    public DealProductFilterSpecification(string? search, DealProductSortBy? orderBy, bool isDescending = false)
    {
        AddInclude(dp => dp.Product!);
        
        // 1. Search by name, description
        if (!string.IsNullOrWhiteSpace(search))
        {
            AddSearchTerm(search);
            AddSearchField("Product.Name");
            AddSearchField("Product.ProductCode");
        }
        
        // 2. Order by
        if (orderBy == null) return;
       
        var sortingField = orderBy switch
        {
            DealProductSortBy.ProductCode => "Product.ProductCode",
            DealProductSortBy.PricePerUnit => DealProductSortBy.PricePerUnit.ToString(),
            DealProductSortBy.Quantity => DealProductSortBy.Quantity.ToString(),
            DealProductSortBy.TotalAmount => "PricePerUnit * Quantity",
            _ => "Product.Name"
        };
        
        AddOrderByField(sortingField);
        if (isDescending)
            ApplyDescending();
    } 
}