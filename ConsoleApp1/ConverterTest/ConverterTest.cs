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

namespace ConverterTest
{
    public class ConverterTest
    {
        [Theory]
        [InlineData(55.55, "55.55")]
        public void Convert(double res, string vinput)
        {
            var loggerMock = new Mock<ILogger<Converter>>();
            var _converter = new Converter(loggerMock.Object);
            Assert.Equal(res, _converter.ConvertData(vinput));
        }
        [Theory]
        [InlineData(11.11, "11,11")]
        public void Conv(double res, string vinput)
        {
            var loggerMock = new Mock<ILogger<Converter>>();
            var _converter = new Converter(loggerMock.Object);
            Assert.Equal(res, _converter.ConvertData(vinput));
        }
        [Theory]
        [InlineData(28.5, "28m5")]
        public void CalсAdd(double res, string vinput)
        {
            var loggerMock = new Mock<ILogger<Converter>>();
            var _converter = new Converter(loggerMock.Object);
            Assert.Throws<Exception>(() => _converter.ConvertData(vinput));
        }

    }
}
