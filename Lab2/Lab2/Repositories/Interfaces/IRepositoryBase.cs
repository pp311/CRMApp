using System.Linq.Expressions;

namespace Lab2.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task<TEntity?> GetByIdAsync(int id);
    Task<(IEnumerable<TEntity> Items, int TotalCount)> GetPagedListAsync(Expression<Func<TEntity, bool>>? expression = null,
                                            string? orderBy = null,
                                            int skip = 0,
                                            int take = -1,
                                            bool ascending = false);
    Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> expression);
    Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression = null);
    Task<double> AvarageAsync(Expression<Func<TEntity, double>> expression);
}
