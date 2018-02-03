using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Counter - {++counter}");
            }
            while (counter < 3);
            Console.WriteLine($"Произведено {counter} итераций");

            //Delay
            Console.ReadKey();
        }
    }
}
