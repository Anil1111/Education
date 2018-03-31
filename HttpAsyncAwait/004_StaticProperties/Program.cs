using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_StaticProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass.Property = 33;
            Console.WriteLine(NotStaticClass.Property);

            //Delay
            Console.ReadKey();
        }
    }
}
