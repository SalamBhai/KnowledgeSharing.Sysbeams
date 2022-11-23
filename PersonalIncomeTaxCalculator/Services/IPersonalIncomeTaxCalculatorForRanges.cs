namespace PersonalIncomeTaxCalculator.Services;

public interface IPersonalIncomeTaxCalculatorForRanges
{
    decimal CalCulateFirst300Thousand(decimal amount);
    decimal CalculateSecond300Thousand(decimal amount);
    decimal CalculateFirst500Thousand(decimal amount);
    decimal CalculateSecond500Thousand(decimal amount);
    decimal CalculateOnePointSixMillion(decimal amount);
    decimal CalculateThreePointTwoMillion(decimal amount);
}
