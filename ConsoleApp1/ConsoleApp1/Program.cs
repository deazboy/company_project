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

        var _converter = serviceProvider.GetService<IConverter>();
        var number1 = _converter.ConvertData(vinput1);
        var number2 = _converter.ConvertData(vinput2);

        var _calculator = serviceProvider.GetService<ICalculator>();
        _calculator.Calculate(symbol, number1, number2);
    }
}




