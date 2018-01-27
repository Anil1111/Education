using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Это число {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("Это числа {0} и {1}", b, c);
            Console.WriteLine("Это числа наоборот {1} и {0}", b, c);

            //Delay
            Console.ReadLine();
        }
    }
}
