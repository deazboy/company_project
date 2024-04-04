using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{    
    public class CalculatorTest
    {
        [Theory]
        [InlineData("+",3, 5, 8),
         InlineData("-",8, 5, 3),
         InlineData("*",3, 5, 15),
         InlineData("/",6, 2, 3)]        
        public void CalсAdd(string sign, double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);
            Assert.Equal(res, _calculator.Calculate(sign, a, b));
            Assert.Equal(res, _calculator.Calculate(sign, a, b));
            Assert.Equal(res, _calculator.Calculate(sign, a, b));
            Assert.Equal(res, _calculator.Calculate(sign, a, b));
        }
       
        [Theory]
        [InlineData("a", 6, 2, 3),
         InlineData("/", 6, 0, 3)]
        public void CalсErr(string sign, double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);
            Assert.Throws<Exception>(() => _calculator.Calculate(sign, a, b));
            Assert.Throws<Exception>(() => _calculator.Calculate(sign, a, b));
        }       
    }
}
