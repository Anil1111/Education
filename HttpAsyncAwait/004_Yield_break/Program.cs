using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Yield_break
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
