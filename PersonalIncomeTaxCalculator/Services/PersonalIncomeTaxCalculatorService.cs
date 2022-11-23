using PersonalIncomeTaxCalculator.Exceptions;
using PersonalIncomeTaxCalculator.Services;

namespace IncomeTaxCalculator.Services;

public class PersonalIncomeTaxCalculatorService : IPersonalIncomeTaxCalculator
{
    
   private readonly IPersonalIncomeTaxCalculatorForRanges _rangeCalculator;

    public PersonalIncomeTaxCalculatorService(IPersonalIncomeTaxCalculatorForRanges rangeCalculator)
    {
        _rangeCalculator = rangeCalculator;
    }

    public  decimal CalculateMonthlyIncomeTax(decimal monthlySalary)
    {
        return (CalculateTaxPaymentPerAnnum(monthlySalary) / 12);
    }


 

    public decimal CalculateTaxableIncome(decimal salary)
    {
        if(salary == 0) throw new NOZeroSalaryException("Cannot Accept A Zero Salary");
        if(salary <= 30000) throw new ArgumentRangeException($"Cannot Accept Value Below The Range of  31000"); 
        
        var annualSalary = salary * 12;
        var consolidatedReliefAllowance = (annualSalary * 0.01m) > 200000 ? (annualSalary * 0.01m) : 200000;
        
    
        var pensionContribution = (annualSalary * 0.08m);
        var grossIncome = annualSalary - pensionContribution;
        var twentyPercentOfGross = (grossIncome * 0.20m);
        var taxableIncome = annualSalary - (consolidatedReliefAllowance + twentyPercentOfGross + pensionContribution);
        return taxableIncome;
    }

    public decimal CalculateTaxPaymentPerAnnum(decimal salary)
    {
        decimal amount = CalculateTaxableIncome(salary);
            decimal tax = 0;
            if(amount<= 300000)
            {
                tax = _rangeCalculator.CalCulateFirst300Thousand(amount);
            }
            else if(amount > 300000 && amount<= 600000)
            {
                tax += _rangeCalculator.CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += _rangeCalculator.CalculateSecond300Thousand(amount);
            }
            else if(amount >600000 && amount<= 1100000)
            {
                tax += _rangeCalculator.CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += _rangeCalculator.CalculateSecond300Thousand(300000);
                amount -= 300000;
                tax += _rangeCalculator.CalculateFirst500Thousand(amount);
            }
            else if(amount > 1100000 && amount <= 1600000)
            {
                tax += _rangeCalculator.CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += _rangeCalculator.CalculateSecond300Thousand(amount);
                amount -= 300000;
                tax += _rangeCalculator.CalculateFirst500Thousand(amount);
                amount -= 500000;
                tax += _rangeCalculator.CalculateSecond500Thousand(amount);
            }
            else if (amount > 1600000 && amount <= 3200000)
            {
                tax += _rangeCalculator.CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += _rangeCalculator.CalculateSecond300Thousand(amount);
                amount -= 300000;
                tax += _rangeCalculator.CalculateFirst500Thousand(amount);
                amount -= 500000;
                tax += _rangeCalculator.CalculateSecond500Thousand(amount);
                amount -= 500000;
                tax += _rangeCalculator.CalculateOnePointSixMillion(amount);
            }
            else if(amount > 3200000)
            {
                tax += _rangeCalculator.CalCulateFirst300Thousand(300000);
                amount -=300000;
                tax += _rangeCalculator.CalculateSecond300Thousand(amount);
                amount -=300000;
                tax += _rangeCalculator.CalculateFirst500Thousand(amount);
                amount -=500000;
                tax += _rangeCalculator.CalculateSecond500Thousand(amount);
                amount -=500000;
                tax += _rangeCalculator.CalculateOnePointSixMillion(amount);
                amount -= 1600000;
                tax += _rangeCalculator.CalculateThreePointTwoMillion(amount);
            }
            return tax;
    }
}
