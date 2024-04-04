using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Converter : IConverter//преобразование строки в число и символ
    {
        private readonly ILogger<Converter> _logger;
        public Converter(ILogger<Converter> logger)
        {
            _logger = logger;
        }
        public double ConvertData(string vinput)
        {
            try 
            {
                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.NumberDecimalSeparator = ".";

                vinput = vinput.Replace(",", ".");
                return Convert.ToDouble(vinput, ci);
            }
            catch 
            {
                _logger.LogError("Значение введено неправильно!");
                throw new Exception("Значение введено неправильно!");
            }
            
        }
    }
}
