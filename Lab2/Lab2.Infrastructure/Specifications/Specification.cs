using System.Linq.Expressions;

namespace Lab2.Infrastructure.Specifications;

public class Specification<T> : ISpecification<T>
{

    public List<Expression<Func<T, object>>> Includes { get; } = new();
    public List<string> IncludeStrings { get; } = new();
    public List<string> SearchFields { get; } = new();
    public string? SearchTerm { get; private set; }
    public Expression<Func<T, bool>>? FilterCondition { get; private set; }
    public string? OrderByField { get; private set; }
    public bool IsDescending { get; private set; }

    protected void AddFilter(Expression<Func<T, bool>> filter)
    {
        FilterCondition = filter;
    }
    
    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }
    
    protected void AddInclude(string includeString)
    {
        IncludeStrings.Add(includeString);
    }

    protected void AddSearchField(string searchField)
    {
        SearchFields.Add(searchField);
    }

    protected void AddSearchTerm(string searchTerm)
    {
        SearchTerm = searchTerm.ToLower().Trim();
    }

    protected void AddOrderByField(string? orderBy)
    {
        OrderByField = orderBy;
    }

    protected void ApplyDescending()
    {
        IsDescending = true;
    }
}