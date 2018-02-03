using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter<3)
            {
                //counter++;
                Console.WriteLine($"Counter {counter++}");
            }
            Console.WriteLine($"Было произведено {counter} циклов");

            //Delay
            Console.ReadKey();
        }
    }
}
