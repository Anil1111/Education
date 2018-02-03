using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Counter - {++counter}");
                continue;
                Console.WriteLine("Эта строка никогда не выполнится");
            }
            while (counter < 3);
            Console.WriteLine($"Произведено {counter} итераций");
            //Delay
            Console.ReadKey();
        }
    }
}
