using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Operators
{
    class Program
    {
        //Суть примера: как только я перегружу оператор - я сразу могу его использовать в том же классе/структуре где он был перегружен.
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine($"Point.Add(a, b) = {Point.Add(a,b)}");
            Console.WriteLine($"Point.Substract(a, b) = {Point.Add(a, b)}");

            //Delay
            Console.ReadKey();
        }
    }
}
