namespace Lab2.Logging;

public interface IExceptionLogger
{
    void LogError(Exception? ex);

    void LogError(Exception ex,
                         string message);

    void LogError(string message);
}