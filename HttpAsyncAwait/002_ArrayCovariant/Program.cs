using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ArrayCovariant
{   //Противоречие между системой типов CLI(Common Language Infrastructure) и системой типов C#.
    //(ковериантность массивов типов-значений НЕСОГЛАСОВАНА)
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[3];

            Console.WriteLine($"array {array is uint[]} {array is int[]}");

            object @object = array;

            Console.WriteLine($"array {@object is uint[]} {@object is int[]}");

            //Delay
            Console.ReadKey();
        }
    }
}
