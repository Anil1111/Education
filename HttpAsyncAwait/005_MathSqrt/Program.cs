using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_MathSqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt() - математическая функция, которая извлекает квадратный корень
            double x = 256;
            double result = Math.Sqrt(x);
            Console.WriteLine($"Квадратный корень числа {x} равен {result}");

            //Delay
            Console.ReadLine();

        }
    }
}
