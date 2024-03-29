using System.Globalization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Console;
using ConsoleApp1;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    public static void Main(string[] args)
    {
        string vinput1, vinput2;
        string symbol;
        

        Console.WriteLine("Введите первое число: ");
        vinput1 = Console.ReadLine();
        Console.WriteLine("Введите знак действия: ");
        symbol = Console.ReadLine();
        Console.WriteLine("Введите второе число: ");
        vinput2 = Console.ReadLine();

        var serviceProvider = new ServiceCollection()
            .AddLogging((loggingBuilder) => loggingBuilder
            .SetMinimumLevel(LogLevel.Trace)
            .AddConsole())
            .AddSingleton<ICalculator, Calculator>()
            .AddSingleton<IConverter, Converter>()
            .BuildServiceProvider();

        var _calculate = serviceProvider.GetService<IConverter>();
        _calculate.ConvertDate(symbol, vinput1, vinput2);

        //мы должны вызвать в calculator метод из converter



    }
}



//while (!double.TryParse(vinput1, out double a1))
//{
//    Console.Write("Введите пожалуйста число: ");
//    vinput1 = Convert.ToDouble(Console.ReadLine());
//}
//Console.WriteLine("Введите знак действия: ");
//symbol = Convert.ToChar(Console.ReadLine());
//while (symbol != '*' | symbol != '+' | symbol != '-' | symbol != '/') 
//{
//    Console.Write("Введите пожалуйста правильный знак: ");
//    symbol = Convert.ToChar(Console.ReadLine());
//}
//Console.WriteLine("Введите второе число: ");
//vinput2 = Console.ReadLine();
//while (!double.TryParse(vinput2, out double b2))
//{
//    Console.Write("Введите пожалуйста число: ");
//    vinput2 = Console.ReadLine();
//}



//       double Addication(double a, double b)
//       {
//           double Sum = a + b;
//          Console.WriteLine($"Сумма ваших чисел равна: {Sum} ");
//            return 0;
//         
//      }
//      double Subtraction(double a, double b)
//      {
//          var Sum = a - b;
//           Console.WriteLine($"Разность ваших чисел равна: {Sum} ");
//           return 0;
//           
//      }
//       double Division(double a, double b)
//       {
//           var Sum = a / b;
//           Console.WriteLine($"Частное ваших чисел равно: {Sum} ");
//          return 0;
//           
//        }
//         double Multiplication(double a, double b)
//         {
//             var Sum = a * b;
//             Console.WriteLine($"Произведение ваших чисел равно: {Sum} ");
//            return 0;
// 
//        }
//        switch (symbol)
//        {
//            case '+':
//                Addication(a, b);
//                break;
//            case '-':
//               Subtraction(a, b);
//               break;
//            case '*':
//                Multiplication(a, b);
//                break;
//           case '/':
//                Division(a, b);
//               break;
//       }
