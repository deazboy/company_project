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


        public double ConvertData(string vinput)
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";

            vinput = vinput.Replace(",", ".");
            return Convert.ToDouble(vinput, ci);
        }
    }
}
