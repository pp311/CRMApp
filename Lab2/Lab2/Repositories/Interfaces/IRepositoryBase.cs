namespace Lab2.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task<TEntity?> GetByIdAsync(int id);
}
