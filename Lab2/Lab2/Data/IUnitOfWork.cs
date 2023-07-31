namespace Lab2.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();    
    Task BeginTransactionAsync();
    Task RollbackAsync();
    Task CommitTransactionAsync();
}
