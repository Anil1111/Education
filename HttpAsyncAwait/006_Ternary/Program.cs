using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, max;
            //Переменной max присваиваем возвращаемое значение тернарного оператора

            max = (a > b) ? a : b; // Если: (a > b) ТО вернуть а ИНАЧЕ: вернуть b

            Console.WriteLine($"Максимально значение из {a} и {b} равно {max}");

            //Delay
            Console.ReadKey();
        }
    }
}
