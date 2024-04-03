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
        [Fact]
        public void Calс()
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);
            double a1 = 3;
            double b1 = 5;
            double res = a1 + b1;

            Assert.Equal(res, _calculator.Calculate("+", a1, b1));


        }





    }
}