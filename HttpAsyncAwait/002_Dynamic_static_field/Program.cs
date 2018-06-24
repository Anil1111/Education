using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _014_Task3;

namespace _002_Dynamic_static_field
{
    class Program
    {
        static dynamic fied = 1;
        static void Main(string[] args)
        {
            Console.WriteLine(fied);

            fied = "Hello world";
            Console.WriteLine(fied);

            fied = DateTime.Now;
            Console.WriteLine(fied);

            //Delay
            Console.ReadKey();
        }
    }
}
