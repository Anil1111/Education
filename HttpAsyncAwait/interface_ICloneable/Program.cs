using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Point original = new Point(100, 200);
            Point clone = original.Clone() as Point;

            Console.WriteLine("Первая проверка");
            Console.WriteLine(original.ToString());
            Console.WriteLine(clone); //можно писать ToString(), а можно и не писать.

            //Изменяем clone.x (при этом original.x не изменяется)
            clone.x = 0;

            //Проверка
            Console.WriteLine("Вторая проверка после изменения");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            //Delay
            Console.ReadKey();
        }
    }
}
