using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Dynamic_delegates
{
    delegate dynamic MyDelegate(dynamic argument);
    class Program
    {
        static dynamic Method(dynamic argument)
        {
            return argument;
        }
        static void Main(string[] args)
        {
            dynamic myDelegate = new MyDelegate(Method);
            dynamic @string = myDelegate("Hello world");

            Console.WriteLine(@string);

            //Delay
            Console.ReadKey();
        }
    }
}
