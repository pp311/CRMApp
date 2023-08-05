using System.Linq.Expressions;

namespace Lab2.Infrastructure.Specifications;

public interface ISpecification<T>
{
    List<Expression<Func<T, object>>> Includes { get; }
    List<string> IncludeStrings { get; }
    List<string> SearchFields { get; }
    public string? SearchTerm { get; }
    Expression<Func<T, bool>>? FilterCondition { get; }
    string? OrderByField { get; }
    public bool IsDescending { get; }
         
}