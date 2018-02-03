using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Roman:
            Console.WriteLine($"Counter = {counter}");
            ++counter;
            if (counter < 3)
                goto Roman;
            Console.WriteLine("The end");

            //Delay
            Console.ReadKey();
        }
    }
}
