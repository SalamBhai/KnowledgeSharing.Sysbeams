namespace PersonalIncomeTaxCalculator.Services;

public interface IPersonalIncomeTaxCalculator
{

    decimal CalculateTaxableIncome(decimal salary);
    decimal CalculateTaxPaymentPerAnnum(decimal salary);
    decimal CalculateMonthlyIncomeTax(decimal monthlySalary);

}
