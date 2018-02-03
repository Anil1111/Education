using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter =0; counter<3;counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
                continue;
                Console.WriteLine("Эта строчка никогда не выполнится!");
            }
            //Delay
            Console.ReadKey();
        }
    }
}
