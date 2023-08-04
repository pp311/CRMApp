namespace Lab2.Domain.Exceptions;

public class EntityValidationException : Exception
{
    public EntityValidationException() { }
    public EntityValidationException(string message) : base(message) { }
    public EntityValidationException(string message, Exception inner) : base(message, inner) { }
}