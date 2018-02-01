using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            Console.WriteLine($"1-е уравнение = {x += y >> x++ * z}");
            Console.WriteLine($"2-е уравнение = {z = ++x & y * 5}");
            Console.WriteLine($"3-е уравнение = {y /= x + 5 | z}");
            Console.WriteLine($"4-е уравнение = {z = x++ & y * 5}");
            Console.WriteLine($"5-е уравнение = {x = y << x++ ^ z}");

            //Delay
            Console.ReadKey();

        }
    }
}
