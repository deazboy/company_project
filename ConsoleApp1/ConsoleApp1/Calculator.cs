using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator : ICalculator //основная логика калькулятора
    {
        private readonly ILogger<Calculator> _logger;
        public Calculator(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Calculator>();
        }
        double result;
        public void Calculate(string symbol, double num1, double num2)
        {
            char s = symbol[0];            
            if (s == '+')
            {
                result = num1 + num2;
                _logger.LogInformation($"Сумма ваших чисел равна: {result} ");
            }
            else if (s == '-')
            {
                result = num1 - num2;
                _logger.LogInformation($"Разность ваших чисел равна: {result} ");
            }
            else if (s == '/')
            {
                if (num2 == 0)
                {
                    _logger.LogInformation("Делить на 0 нельзя!");
                }
                else
                {
                    result = num1 / num2;
                    _logger.LogInformation($"Частное ваших чисел равно: {result} ");
                }
            }
            else if (s == '*')
            {
                result = (num1 * num2);
                _logger.LogInformation($"Произведение ваших чисел равно: {result} ");
            }
            else { throw new Exception("Символ введен неправильно!"); }
        }
    }
}