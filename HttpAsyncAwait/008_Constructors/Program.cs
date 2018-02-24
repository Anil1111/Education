using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point("A");
            Console.WriteLine($"{point.Name}.X = {point.X}, {point.Name}.Y = {point.Y}");

            //конструктор private, по этому тут и ошибка!
            //Point point1 = new Point("A",1,2);
            //Console.WriteLine($"{point1.Name}.X = {point1.X}, {point1.Name}.Y = {point1.Y}");

            //Даже конструктор по умолчанию может быть protected
            //Point point = new Point();

            //Delay
            Console.ReadKey();
        }
    }
}
