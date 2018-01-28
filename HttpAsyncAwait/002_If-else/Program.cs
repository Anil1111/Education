using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            if (a < b)
            {
                Console.WriteLine($"{nameof(a)} < {nameof(b)}");
            }
            else
            {
                Console.WriteLine($"{nameof(a)} > {nameof(b)}");
            }

            //Delay
            Console.ReadLine();
        }
    }
}
