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
                                            int take = 0,
                                            bool isDescending = false);
}
