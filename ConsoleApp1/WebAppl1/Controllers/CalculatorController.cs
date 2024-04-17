using ConsoleApp1;
using Microsoft.AspNetCore.Mvc;

namespace WebAppl1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly IConverter _converter;
        private readonly ICalculator _calculator;

        public CalculatorController(ILogger<CalculatorController> logger, IConverter converter, ICalculator calculator)
        {
            _logger = logger;
            _converter = converter;
            _calculator = calculator;
        }

        [HttpGet(Name = "GetCalculation")]
        public string Get(string v1, string v2, string symbol)
        {
            double result = 0;
            try
            {
                var number1 = _converter.ConvertData(v1);
                var number2 = _converter.ConvertData(v2);
                result = _calculator.Calculate(symbol, number1, number2);
            }
            catch (Exception ex)
            {
                _logger.LogError("Ошибка вычисления", ex);
                return "ошибка вычисления";
            }
            return result.ToString();
        }

    }
}
