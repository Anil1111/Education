using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myValue = 'a' > 'b';

            Console.WriteLine("a: " + (int)'a');
            Console.WriteLine("b: " + (int)'b');

            bool myValue2 = "str" == "str"; // со строками можно использовать либо !=  либо == 
            Console.WriteLine("Символ :" + myValue);
            Console.WriteLine("Строка :" + myValue2);

            //Delay
            Console.ReadKey();
        }
    }
}
