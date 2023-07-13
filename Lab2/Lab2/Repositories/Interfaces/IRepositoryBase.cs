using System.Linq.Expressions;

namespace Lab2.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task<TEntity?> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? expression = null,
                                            string? orderBy = "",
                                            int skip = 0,
                                            int take = 0,
                                            bool ascending = false);
    Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> expression);
    Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression = null);
}
