namespace IncomeTaxCalculator.Services;

public class PersonalIncomeTaxCalculator
{
    public static decimal CalculateIncomeTax(decimal monthlySalary)
    {
        var annualIncome = monthlySalary * 12;
        decimal monthlyTax = 0;

        if (annualIncome <= 300000)
        {
            var annualTax = annualIncome * 0.07m;
            monthlyTax = annualTax;
        }
        else if (annualIncome >= 301000 && annualIncome <= 600000)
        {
            var firstAnnualTax = 300000 * 0.07m;
            var amountRemaining = annualIncome - 300000;
            if (amountRemaining >= 300000)
            {
                var secondAnnualTax = annualIncome * 0.11m;
                monthlyTax = firstAnnualTax + secondAnnualTax;
            }
        }

        else if (annualIncome > 600000 && annualIncome <= 1100000)
        {
            var firstAnnualTax = 300000 * 0.07m;
            var amountRemaining = annualIncome - 300000;
            if (amountRemaining >= 300000)
            {
                var secondAnnualTax = amountRemaining * 0.11m;
                monthlyTax = firstAnnualTax + secondAnnualTax;
            }
            amountRemaining = amountRemaining - 300000;
            if (amountRemaining <= 500000)
            {
                var thirdAnnualTax = amountRemaining * 0.15m;
                monthlyTax += thirdAnnualTax;
            }
        }
        else if (annualIncome > 1100000 && annualIncome <= 1600000)
        {
            
            var firstAnnualTax = 300000 * 0.07m;
            var amountRemaining = annualIncome - 300000;
            if (amountRemaining >= 300000)
            {
                var secondAnnualTax = amountRemaining * 0.11m;
                monthlyTax = firstAnnualTax + secondAnnualTax;
            }
            amountRemaining = amountRemaining - 300000;
            if (amountRemaining <= 500000)
            {
                var thirdAnnualTax = amountRemaining * 0.15m;
                monthlyTax += thirdAnnualTax;
            }
            amountRemaining = amountRemaining - 500000;
            if (amountRemaining <= 500000)
            {
                var fourthAnnualTax = amountRemaining * 0.19m;
                monthlyTax += fourthAnnualTax;
            }
        }
        else if(annualIncome > 1600000 && annualIncome <= 3200000)
        {
            var firstAnnualTax = 300000 * 0.07m;
            var amountRemaining = annualIncome - 300000;
            if (amountRemaining >= 300000)
            {
                var secondAnnualTax = amountRemaining * 0.11m;
                monthlyTax = firstAnnualTax + secondAnnualTax;
            }
            amountRemaining = amountRemaining - 300000;
            if (amountRemaining <= 500000)
            {
                var thirdAnnualTax = amountRemaining * 0.15m;
                monthlyTax += thirdAnnualTax;
            }
            amountRemaining = amountRemaining - 500000;
            if (amountRemaining <= 500000)
            {
                var fourthAnnualTax = amountRemaining * 0.19m;
                monthlyTax += fourthAnnualTax;
            }
            amountRemaining = amountRemaining - 500000;
            if(amountRemaining <= 1600000)
            {
                var fifthAnnualTax = amountRemaining * 0.21m;
                monthlyTax+= fifthAnnualTax;
            }

        }

      else 
      {
          var firstAnnualTax = 300000 * 0.07m;
            var amountRemaining = annualIncome - 300000;
            if (amountRemaining >= 300000)
            {
                var secondAnnualTax = amountRemaining * 0.11m;
                monthlyTax = firstAnnualTax + secondAnnualTax;
            }
            amountRemaining = amountRemaining - 300000;
            if (amountRemaining <= 500000)
            {
                var thirdAnnualTax = amountRemaining * 0.15m;
                monthlyTax += thirdAnnualTax;
            }
            amountRemaining = amountRemaining - 500000;
            if (amountRemaining <= 500000)
            {
                var fourthAnnualTax = amountRemaining * 0.19m;
                monthlyTax += fourthAnnualTax;
            }
            amountRemaining = amountRemaining - 500000;
            if(amountRemaining <= 1600000)
            {
                var fifthAnnualTax = amountRemaining * 0.21m;
                monthlyTax+= fifthAnnualTax;
            }
            amountRemaining = amountRemaining - 1600000;
            if(amountRemaining <= 1600000)
            {
                var sixthAnnualTax = amountRemaining * 0.24m;
                monthlyTax+= sixthAnnualTax;
            }
       }
      return monthlyTax;
    }
   
   public static decimal CalculateMonthlyIncomeTax(decimal monthlySalary)
   {
        return (CalculateIncomeTax(monthlySalary)/12);
   }
}
