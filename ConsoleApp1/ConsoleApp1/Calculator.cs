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
        double result;
        public void Calculate(string symbol, double b, double b1)
        {
            char s = symbol[0];
            //if (s != '/' | s != '+' | s != '-' | s != '*')
            //{
            //    throw new Exception("Символ введен неправильно!");
            //}
            if (s == '+')
            {
                result = b + b1;
                Console.WriteLine($"Сумма ваших чисел равна: {result} ");
            }
            else if (s == '-')
            {
                result = b - b1;
                Console.WriteLine($"Разность ваших чисел равна: {result} ");
            }
            else if (s == '/')
            {
                if (b1 == 0)
                {
                    Console.WriteLine("Делить на 0 нельзя!");
                }
                else
                {
                    result = b / b1;
                    Console.WriteLine($"Частное ваших чисел равно: {result} ");
                }
            }
            else if (s == '*')
            {
                result = (b * b1);
                Console.WriteLine($"Произведение ваших чисел равно: {result} ");
            }
            else { throw new Exception("Символ введен неправильно!"); }
            
        }
    }
}
