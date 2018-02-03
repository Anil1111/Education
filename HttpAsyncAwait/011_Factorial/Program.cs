using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 4;
            int factorial = 1;

            do
            {
                //Сначала умножение, потом декремент
                factorial *= counter--;
                //Данная строка эквивалентна:
                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 1);
            Console.WriteLine($"Факториал {counter} равен {factorial}");

            //Delay
            Console.ReadKey();
        }
    }
}
