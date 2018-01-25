using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Директивы_препроцессора
{
    class Program
    {
        public static int x;
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Отладка запущена");
            for ( int i =0; i<=10; i++)
            {
                x += i;
                Console.WriteLine($"x= {x}");
            }
#else
            Console.WriteLine("Отладка не запущена");
#endif
            Console.ReadKey();
        }
    }
}
