using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter=0;counter<3;counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
                break;
                Console.WriteLine("Эта строчка никогда не выполнится");
            }
            //Delay
            Console.ReadKey();
        }
    }
}
