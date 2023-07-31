using System.Linq.Expressions;
using Lab2.Data;
using Lab2.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Lab2.Entities;

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
        if (typeof(AuditableEntity).IsAssignableFrom(typeof(TEntity)))
        {
            (entity as AuditableEntity)!.CreatedAt = DateTime.UtcNow;
            (entity as AuditableEntity)!.ModifiedAt = DateTime.UtcNow;
        }
        DbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        if (typeof(AuditableEntity).IsAssignableFrom(typeof(TEntity)))
        {
            (entity as AuditableEntity)!.ModifiedAt = DateTime.UtcNow;
        }
        DbSet.Update(entity);
    }

    public void Delete(TEntity entity)
    {
        DbSet.Remove(entity);
    }

    public virtual async Task<TEntity?> GetByIdAsync(int id)
    {
        var entity = await DbSet.FindAsync(id);
        // if (entity != null) _context.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    // Use in repository layer only
    protected async Task<(IEnumerable<TEntity>, int)> GetPagedListFromQueryableAsync(IQueryable<TEntity> query,
                                                                                     int skip,
                                                                                     int take)
    {
        // Count total items before paging
        var totalCount = await query.CountAsync();
        
        // If skip and take provided, apply them 
        if (skip >= 0  && take > 0)
            query = query.Skip(skip).Take(take);
        
        return (await query.ToListAsync(), totalCount);
    }

    // Apply sorting if the orderBy field exists in TEntity,
    // If sorting field is in join table, you must write custom sorting logic
    protected IQueryable<TEntity> ApplySortingIfFieldExistsQueryable(IQueryable<TEntity> query,
                                                                     string? orderBy,
                                                                     bool isDescending = false)
    {
        if (!string.IsNullOrEmpty(orderBy))
        {
            // Check if the orderBy field exists in TEntity
            var properties = typeof(TEntity).GetProperties();
            var orderByProperty =
                properties.FirstOrDefault(p => string.Equals(p.Name, orderBy, StringComparison.OrdinalIgnoreCase));

            if (orderByProperty != null)
            {
                // Apply the order, default is ascending
                query = isDescending ? query.OrderBy(orderByProperty.Name + " desc") : query.OrderBy(orderByProperty.Name);
            }
        }
        return query;
    }

    // Get list with paging, filtering, ordering
    public async Task<(IEnumerable<TEntity> Items, int TotalCount)> GetPagedListAsync(Expression<Func<TEntity, bool>>? expression,
                                                                                     string? orderBy,
                                                                                     int skip,
                                                                                     int take,
                                                                                     bool isDescending)
    {
        // Filtering with expression
        var query = DbSet.AsNoTracking();
        if (expression != null)
        {
            query = query.Where(expression);
        }
        // If orderBy provided, check if the orderBy field exists in TEntity and apply the order 
        query = ApplySortingIfFieldExistsQueryable(query, orderBy, isDescending);
        
        return await GetPagedListFromQueryableAsync(query, skip, take);
    }

    public async Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await DbSet.Where(expression).ToListAsync();
    }
}
