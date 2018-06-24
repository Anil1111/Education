using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Dynamic_generic_delegate
{
    delegate R MyDelegate<T, R>(T argument);
    class Program
    {
        static dynamic Method(dynamic argument)
        {
            return argument;
        }
        static void Main(string[] args)
        {
            dynamic myDelegate = new MyDelegate<dynamic, dynamic>(Method);
            MyDelegate<dynamic, dynamic> myDelegate2 = Method;
            dynamic @string = myDelegate("Hello world");
            Console.WriteLine(@string);

            //Delay
            Console.ReadKey();
        }
    }
}
