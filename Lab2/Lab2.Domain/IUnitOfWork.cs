namespace Lab2.Domain;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();    
    Task BeginTransactionAsync();
    Task RollbackAsync();
    Task CommitTransactionAsync();
}
