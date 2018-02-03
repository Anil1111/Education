using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            if(condition == true)
            {
                goto Label;
            }
            Console.WriteLine("First Line");

            Label:
            Console.WriteLine("Second Line");

            //Delay
            Console.ReadKey(); 
        }
    }
}
