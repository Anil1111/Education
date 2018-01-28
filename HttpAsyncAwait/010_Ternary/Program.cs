using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение квадратнта в котором лежит заданная точка.
            // Для упрощения примера условимся, что точка не будет лежать в центре координат и на координатных осях,
            // это значит, что x и y - не могут быть равны 0.

            int x = -10, y = 50;
            // На самом деле, не рекомендуется вкладывать тернарные операторы, так, как это ухудшает чтение кода.

            string quadrant = ((x > 0) ? (y > 0 ? "Первом квадранте" : "Четвертом квадранте"): (y > 0 ? "Втором квадранте" : "Третъем квадранте"));

            Console.WriteLine($"Точка с координатами {x};{y} находится в {quadrant}");

            //Delay
            Console.ReadKey();
        }
    }
}
