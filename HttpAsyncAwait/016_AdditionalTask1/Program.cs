using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointA = new Point(1, 2, 3);
            var pointB = new Point(4, 5, 6);
            var pointC = pointA + pointB;

            Console.WriteLine($"PointA {pointA} + PointB {pointB} = PointC {pointC}");

            //Delay
            Console.ReadKey();
        }

    }
}
