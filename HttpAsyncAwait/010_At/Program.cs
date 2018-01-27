using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_At
{
    class Program
    {
        static void Main(string[] args)
        {
            //Использование ключневых слов языка C# в качестве идентефикаторов.
            //int bool = 5; Illegal
            int @bool = 7; //Legal

            //Символ @ не является частью идентефикатора, поэтому @myVariable - это тоже самое, что и myVariable.
            string @myVariable = "Hello";
            Console.WriteLine(myVariable);

            //Delay
            Console.ReadLine();
        }
    }
}
