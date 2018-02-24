using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Taskk
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A",1,2), new Point("B", 3, 4), new Point("C", 2, 6), new Point("D", 10, 20), new Point("E", 32, 45));

            Console.WriteLine($"{figure.Type}, P = {figure.PerimeretCalculator()}");

            //Delay
            Console.ReadKey();
        }
    }
}
