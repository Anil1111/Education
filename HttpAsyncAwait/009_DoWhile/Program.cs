using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Циклическая конструкция с постусловием do-while
            // с досрочным выходом из цикла

            int counter = 0;
            do
            {
                Console.WriteLine($"Counter {++counter}");
                break;
                Console.WriteLine("Эта строчка никогда не выполнится");
            }
            while (counter < 3);

            Console.WriteLine($"Итераций призведено {counter}");

            //Delay
            Console.ReadKey();
        }
    }
}
 