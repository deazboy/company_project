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
        private readonly ICalculator _calculator;
        public Converter(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void ConvertDate(string symbol, string vinput1, string vinput2)
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";

            vinput1 = vinput1.Replace(",", ".");
            double a = Convert.ToDouble(vinput1, ci);
            double b = double.Parse(vinput1, ci);
           

            vinput2 = vinput1.Replace(",", ".");
            double a1 = Convert.ToDouble(vinput2, ci);
            double b1 = double.Parse(vinput2, ci);
           
            _calculator.Calculate (symbol, b, b1);
        }
    }
}
