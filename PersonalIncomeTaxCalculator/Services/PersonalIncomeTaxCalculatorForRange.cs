namespace PersonalIncomeTaxCalculator.Services;

public class PersonalIncomeTaxCalculatorForRange : IPersonalIncomeTaxCalculatorForRanges
{
    public decimal CalCulateFirst300Thousand(decimal amount)
    {
       return (0.07m * amount);
    }

    public decimal CalculateSecond500Thousand(decimal amount)
    {
      return (amount * 0.19m);
    }

    public decimal CalculateOnePointSixMillion(decimal amount)
    {
       return (amount * 0.21m);
    }

    public decimal CalculateSecond300Thousand(decimal amount)
    {
        return (0.11m * amount);
    }

    public decimal CalculateFirst500Thousand(decimal amount)
    {
        return (0.15m * amount);
    }

    public decimal CalculateThreePointTwoMillion(decimal amount)
    {
       return (0.24m * amount);
    }
}
