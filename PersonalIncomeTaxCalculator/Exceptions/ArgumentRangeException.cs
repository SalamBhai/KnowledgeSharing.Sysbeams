namespace PersonalIncomeTaxCalculator.Exceptions;

public class ArgumentRangeException : Exception
{
     public ArgumentRangeException(string? message, Exception? innerException = null) : base(message, innerException)
    {
    }
}
