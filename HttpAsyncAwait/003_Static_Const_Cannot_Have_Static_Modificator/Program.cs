using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Static_Const_Cannot_Have_Static_Modificator
{
    class Program
    {
        static void Main(string[] args)
        {
            //NotStaticClass.e = 2; мы не можем менять константу.
            Console.WriteLine($"e = {NotStaticClass.e}");

            //Delay
            Console.ReadKey();
        }
    }
}
