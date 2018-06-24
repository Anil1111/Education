using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Dynamic_arguments_and_return_type
{
    class Program
    {
        //Динамические типы аргументов и возвращаемых значений методов.
        static dynamic Method(dynamic argument)
        {
            return "Hello" + argument + "!";
        }
        static void Main(string[] args)
        {
            string @string = Method("friend");
            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
