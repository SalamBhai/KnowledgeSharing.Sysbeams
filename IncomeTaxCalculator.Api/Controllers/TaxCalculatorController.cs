using Microsoft.AspNetCore.Mvc;
using PersonalIncomeTaxCalculator.Services;

namespace IncomeTaxCalculator.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaxCalculatorController : ControllerBase
{
     private readonly IPersonalIncomeTaxCalculator _taxCalculator;
        public TaxCalculatorController(IPersonalIncomeTaxCalculator taxCalculator) => _taxCalculator = taxCalculator;

        [HttpGet("TaxPayment")]
        public IActionResult GetCalculatedTaxPayment(decimal salary)
        {
            var taxableIncome = _taxCalculator.CalculateTaxableIncome(salary);
            var taxPayment = _taxCalculator.CalculateMonthlyIncomeTax(salary);
            var data = new { taxableIncome = taxableIncome, taxPayment = taxPayment };
            Console.WriteLine(data);
            return Ok(data);
        }
}
