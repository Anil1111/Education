using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine($"a < b = {a < b}");
            Console.WriteLine($"a > b = {a > b}");

            Console.WriteLine($"a <= b = {a <= b}");
            Console.WriteLine($"a >= b = {a >= b}");

            Console.WriteLine("-".PadRight(15));

            Point c = new Point(1, 1);

            Console.WriteLine($"a <= c = {a <= c}");
            Console.WriteLine($"a >= c = {a >= c}");

            //Delay
            Console.ReadKey();
        }
    }
}
