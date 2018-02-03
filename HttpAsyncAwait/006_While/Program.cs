using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter<3)
            {
                Console.WriteLine($"Counter - {++counter}");

                continue;//Есть смылс использовать в связке с условной конструкцией

                Console.WriteLine("Эта строка никогда не выполнится");
            }
            Console.WriteLine($"Произведено {counter} итераций");

            //Delay
            Console.ReadKey();
        }
    }
}
