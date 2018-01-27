using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10, y = 15, z = 28, rez = 0;
            rez = (double)(x + y + z) / 3;
            Console.WriteLine("Среднее арифметическое чисел {0} , {1} ,{2} равняется {3}", x, y, z, rez);

            //Delay
            Console.ReadKey();
        }
    }
}
