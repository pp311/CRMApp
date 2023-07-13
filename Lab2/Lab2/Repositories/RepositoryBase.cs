using System.Linq.Expressions;
using Lab2.Data;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Lab2.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly CRMDbContext _context;
    private DbSet<TEntity>? _dbSet;

    protected DbSet<TEntity> DbSet => _dbSet ??= _context.Set<TEntity>();

    protected RepositoryBase(CRMDbContext context)
    {
        _context = context;
    }

    public void Add(TEntity entity)
    {
        DbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        DbSet.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        DbSet.Remove(entity);
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity != null) _context.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    // Get list with paging, filtering, ordering
    public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? expression,
                                                         string? orderBy,
                                                         int skip,
                                                         int take,
                                                         bool isDescending)
    {
        // 1. Filtering with expression
        var query = DbSet.AsQueryable();
        if (expression != null)
        {
            query = query.Where(expression);
        }
        // 2. If orderBy provided, check if the property exists in TEntity and apply the order 
        if (!string.IsNullOrEmpty(orderBy))
        {
            // If field not exist, early return the list
            var properties = typeof(TEntity).GetProperties();
            var orderByProperty =
                properties.FirstOrDefault(p => string.Equals(p.Name, orderBy, StringComparison.OrdinalIgnoreCase));
            if (orderByProperty == null) return await query.ToListAsync();
            // Apply the order, default is ascending
            query = isDescending ? query.OrderBy(orderByProperty.Name + " desc") : query.OrderBy(orderByProperty.Name);
            // 3. If skip and take provided, apply them (only use skip&take with OrderBy)
            if (skip >= 0 && take >= 0)
            {
                query = query.Skip(skip).Take(take);
            }
        }
        return await query.ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await DbSet.Where(expression).ToListAsync();
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression = null)
    {
        if (expression == null)
        {
            return await DbSet.CountAsync();
        }
        return await DbSet.CountAsync(expression);
    }
}
