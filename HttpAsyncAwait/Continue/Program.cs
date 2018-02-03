using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10;i++)
            {
                Console.WriteLine("1 строка");
                if(i<5)
                {
                    continue;
                }
                Console.WriteLine("2 строка");
            }
            //Delay
            Console.ReadKey();
        }
    }
}
