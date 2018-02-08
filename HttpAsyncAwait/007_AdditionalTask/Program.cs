using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_AdditionalTask
{
    class Program
    {
        static double CountAvarageValue(double number1, double number2, double number3, out double avarageValue)
        {
            avarageValue = (number1 + number2 + number3) / 3;
            return avarageValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double sum;
            CountAvarageValue(number1, number2, number3, out sum);
            Console.WriteLine(sum);

            //Delay
            Console.ReadKey();

        }
    }
}
