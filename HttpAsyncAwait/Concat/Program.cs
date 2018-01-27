using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World";
            string result = String.Concat(str1, str2);

            Console.WriteLine(result);

            //Delay
            Console.ReadKey();
        }
    }
}
