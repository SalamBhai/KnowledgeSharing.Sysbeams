namespace PersonalIncomeTaxCalculator.Exceptions;

public class NOZeroSalaryException : Exception
{
    public NOZeroSalaryException(string? message, Exception? innerException = null) : base(message, innerException)
    {
    }
}
