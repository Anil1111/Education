using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Dynamic_ref_out
{
    class Program
    {
        static dynamic Method(ref dynamic argument1, out dynamic argument2)
        {
            argument1 = ++argument1;
            argument2 = 2;

            return default(dynamic);
        }
        static void Main(string[] args)
        {
            dynamic variable1 = 0, variable2;

            Method(ref variable1, out variable2);

            Console.WriteLine(variable1);
            Console.WriteLine(variable2);

            //Delay
            Console.ReadKey();
        }
    }
}
