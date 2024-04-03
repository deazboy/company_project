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
        public Calculator(ILogger<Calculator> logger)
        {
            _logger = logger;
        }
        double result;
        public double Calculate(string symbol, double num1, double num2)
        {
            char s = symbol[0];
            if (s == '+')
            {
                result = num1 + num2;               
            }
            else if (s == '-')
            {
                result = num1 - num2;
            }
            else if (s == '/')
            {
                if (num2 == 0)
                {
                    _logger.LogError("Делить на 0 нельзя!");
                    throw new Exception("На 0 делить нельзя!");
                }
                else
                {
                    result = num1 / num2;                    
                }
            }
            else if (s == '*')
            {
                result = (num1 * num2);                
            }
            else {
                _logger.LogError("Символ введен неправильно!");
                throw new Exception("Символ введен неправильно!"); 
            }
            return result;
        }
    }
}