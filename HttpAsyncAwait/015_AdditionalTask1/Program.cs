using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace _015_AdditionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите желаемую операцию: '+' - сложение,\n" +
                              " '-' - вычетание,\n" +
                              " '*' - умножение,\n" +
                              " '/' - деление\n");
            var operationSign = Console.ReadLine();
            var calculator = new Calculator();
            double? result = 0;
            bool calculation = true;
            switch (operationSign)
            {
                case "+":
                    result = calculator.Add(number1, number2);
                    break;
                case "-":
                    result = calculator.Sub(number1, number2);
                    break;
                case "*":
                    result = calculator.Mul(number1, number2);
                    break;
                case "/":
                    result = calculator.Div(number1, number2);
                    break;
                default:
                    Console.WriteLine("Неправильный знак операции");
                    calculation = false;
                    break;
            }

            if (calculation && result != null)
            {
                Console.WriteLine($"{number1} {operationSign} {number1} = {result}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
