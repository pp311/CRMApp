namespace Lab2.Logging;

public class ExceptionLogger : IExceptionLogger
{
    private ILogger<ExceptionLogger> _logger;
    
    public ExceptionLogger(ILogger<ExceptionLogger> logger)
    {
        _logger = logger;
    }
    
    public void LogError(Exception? ex)
    {
        if (ex != null)
            _logger.LogError(ex, ex.Message);
    }
    
    public void LogError(Exception ex, string message)
    {
        _logger.LogError(ex, message);
    }
    
    public void LogError(string message)
    {
        _logger.LogError(message);
    }
}