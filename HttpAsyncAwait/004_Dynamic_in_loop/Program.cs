using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Dynamic_in_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (dynamic i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello world");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
