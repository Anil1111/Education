using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task23
{
    class Program
    {
        private delegate double Function(double arg1, double arg2);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор +,-,*,/");
            var sign = Console.ReadLine();

            Function func = null;

            switch (sign)
            {
                case "+":
                    func = (a, b) => a + b;
                    break;
                case "-":
                    func = (a, b) => a - b;
                    break;
                case "*":
                    func = (a, b) => a * b;
                    break;
                case "/":
                    func = (a, b) =>
                    {
                        if (b != 0)
                        {
                            return a / b;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный знак");
                    break;

            }
            Console.WriteLine(new string('-',50));
            if(func!=null)
                Console.WriteLine($"{func(number1,number2)}");

            //Delay
            Console.ReadKey();
        }
    }
}
