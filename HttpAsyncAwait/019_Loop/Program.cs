using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Варианты создания бесконечных цыклов

            //1
            int i = 0;
            while (true)
            {
                i++;
                Console.WriteLine($"Бесконечный цикл while, i = {i}");
            }

            //2
            do
            {
                i++;
                Console.WriteLine($"Бесконечный цикл do-while, i = {i}");
            }
            while (true);

            //3
            for (; ; )
            {
                i++;
                Console.WriteLine($"Бесконечный цикл for, i = {i}");
            }

            for (int a =5; a<10;a++)
            {
                a--;
            }

            //Delay
            Console.ReadKey();
        }
    }
}
