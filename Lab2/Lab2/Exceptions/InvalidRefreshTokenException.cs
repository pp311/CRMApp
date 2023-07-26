namespace Lab2.Exceptions;

public class InvalidRefreshTokenException : Exception
{
    public InvalidRefreshTokenException(string message) : base(message)
    {
    }
}