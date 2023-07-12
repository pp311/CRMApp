namespace Lab2.Data;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly CRMDbContext _context;
    private bool _disposed;

    public UnitOfWork(CRMDbContext context)
    {
        _context = context;
    }

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _context.Dispose();
            _disposed = true;
        }
    }
}
