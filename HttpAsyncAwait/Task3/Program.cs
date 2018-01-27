using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Мой пример!
            const double pi = Math.PI;
            double radius = 5D;
            double square = pi * (Math.Pow(radius, 2));
            Console.WriteLine($"Площадь круга с радиусом {(double)radius} равняется {(double)square}");

            //С видео
            //const float pi = 3.141f;
            //int r = 15;
            //Console.WriteLine("Площадь круга {0}", (float)(pi * r * r));

            //Delay
            Console.ReadKey();
        }
    }
}
