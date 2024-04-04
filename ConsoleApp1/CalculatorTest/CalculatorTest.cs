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
        [InlineData(3, 5, 8)]
        public void CalсAdd(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);           
            Assert.Equal(res, _calculator.Calculate("+", a, b));
        }
        [Theory]
        [InlineData(8, 5, 3)]
        public void CalсDiff(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);           
            Assert.Equal(res, _calculator.Calculate("-", a, b));
        }
        [Theory]
        [InlineData(3, 5, 15)]
        public void CalсMult(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);           
            Assert.Equal(res, _calculator.Calculate("*", a, b));
        }
        [Theory]
        [InlineData(6, 2, 3)]
        public void CalсDiv(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);            
            Assert.Equal(res, _calculator.Calculate("/", a, b));
        }
        [Theory]
        [InlineData(6, 2, 3)]
        public void CalсErr(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);
            Assert.Throws<Exception>(() => _calculator.Calculate("a", a, b));
        }
        [Theory]
        [InlineData(6, 0, 3)]
        public void CalсDivO(double a, double b, double res)
        {
            var loggerMock = new Mock<ILogger<Calculator>>();
            var _calculator = new Calculator(loggerMock.Object);
            Assert.Throws<Exception>(() => _calculator.Calculate("/", a, b));
        }

    }
}