namespace Lab2.Data;

public interface IUnitOfWork
{
    Task<int> CommitAsync();    
}
