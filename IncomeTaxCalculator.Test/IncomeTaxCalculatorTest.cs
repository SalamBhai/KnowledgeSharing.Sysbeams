using IncomeTaxCalculator.Services;
using PersonalIncomeTaxCalculator.Exceptions;
using PersonalIncomeTaxCalculator.Services;
using Xunit;

namespace IncomeTaxCalculator.Test;

public class IncomeTaxCalculatorTest
{
    private IPersonalIncomeTaxCalculator _taxCalculator;
    private IPersonalIncomeTaxCalculatorForRanges _taxCalculatorRange;
    public IncomeTaxCalculatorTest()
    {
        _taxCalculatorRange = new PersonalIncomeTaxCalculatorForRange();
        _taxCalculator = new PersonalIncomeTaxCalculatorService(_taxCalculatorRange);
    }
    [Fact]
    public void CalculateTaxableIncome_TaxableIncomeUsed_EquatesTo3400000()
    {
        //Arrange
        decimal monthlySalary = 416666.6666666667m;
        var expectedReturn = 3400000.000000000288m;
        //Act
        var result = _taxCalculator.CalculateTaxableIncome(monthlySalary);
        //Assert
        Assert.StrictEqual(expectedReturn, result);
        Assert.True(result == expectedReturn);
        var expectedType = expectedReturn.GetType();
        var resultType = result.GetType();
        Assert.Same(expectedReturn.GetType(), result.GetType());
    }

    [Fact]
    public void CalculateIncomeTax_CalculatesForTaxableIncomeOf3400000_Returns608000()
    {
        //Arrange
        decimal monthlySalary = 416666.6666666667m;
        var expectedReturn = 608000.00000000006912m;
        //Act
        var result = _taxCalculator.CalculateTaxPaymentPerAnnum(monthlySalary);

        //Assert
        Assert.Same(expectedReturn, result);
    }
  
    [Fact]
    public void CalculateTaxableIncome_IncomeLessThanZero_ShouldReturnNoZeroSalaryException()
    {

        //assert
        Assert.Throws<NOZeroSalaryException>(() => _taxCalculator.CalculateTaxableIncome(0));
    }

}
