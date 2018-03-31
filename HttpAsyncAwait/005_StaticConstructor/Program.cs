using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(NotStaticClass.ReadOnlyField);

            //Delay
            Console.ReadKey();
        }
    }
}
