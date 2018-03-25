using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            for (int i = 0; i < 6; i++) //тут будет ошибка т.к нужно чтобы итераций было 5 а не 6!
            {
                instance[i] = $"string {i}";
            }

            for (int i = 0; i < 6; i++) //тут будет ошибка т.к нужно чтобы итераций было 5 а не 6!
            {
                Console.WriteLine(instance[i]);
            }


            //Delay
            Console.ReadKey();
        }
    }
}
