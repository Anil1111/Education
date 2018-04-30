using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task22
{
    class Program
    {
        private delegate double Function(double arg1, double arg2);
        static void Main(string[] args)
        {
            Function add = (arg1, arg2) => arg1 + arg2;
            var sub = new Function(delegate (double arg1, double arg2) { return arg1 - arg2; });
            Function mul = delegate (double arg1, double arg2) { return arg1 * arg2; };
            Function div = (arg1, arg2) => { return arg2 == 0 ? 0 : arg1 / arg2; };

            Console.WriteLine("Выберите действие и введите номер: сложение - 1, вычитание - 2, умножение - 3, деление - 4");
            var numberOfAction = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите первое число");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var number2 = Convert.ToDouble(Console.ReadLine());

            switch (numberOfAction)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2} = {add(number1, number2)}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} = {sub(number1, number2)}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2} = {mul(number1, number2)}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2} = {div(number1, number2)}");
                    break;
            }

            //Delay
            Console.ReadKey();
        }
    }
}
