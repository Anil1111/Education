using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 1, "A"), new Point(1, 4, "B"), new Point(4, 4, "C"), new Point(5, 6, "C"), new Point(7, 9, "C"));

            Console.Write($"{figure.Type}, P= {figure.PerimeterCalculator()}");


            //Delay
            Console.ReadKey();
        }
    }
}
