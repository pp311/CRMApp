using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Lab2.Infrastructure.Specifications;

public static class SpecificationEvaluator<TEntity> where TEntity : class
{
    public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> query, ISpecification<TEntity>? specification = null)
    {
        if (specification == null)
            return query;
        
        // Filtering
        if (specification.FilterCondition != null)
            query = query.Where(specification.FilterCondition);

        // Include related data
        query = specification.Includes.Aggregate(
            query, 
            (current, include) => current.Include(include));

        query = specification.IncludeStrings.Aggregate(
            query,
            (current, include) => current.Include(include));

        // Searching
        if (!string.IsNullOrEmpty(specification.SearchTerm))
        {
            var searchClause = string.Empty;
            foreach (var searchField in specification.SearchFields)
            {
                searchClause += searchClause == string.Empty ? string.Empty : " || ";
                searchClause += $"{searchField} != null && {searchField}.ToLower().Contains(\"{specification.SearchTerm}\")";
            }
            query = query.Where(searchClause);
        }
        
        // Ordering
        if (specification.OrderByField != null)
        {
            query = specification.IsDescending ? query.OrderBy(specification.OrderByField + " desc") 
                                               : query.OrderBy(specification.OrderByField);
        }

        return query;
    }
}