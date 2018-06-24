using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Dynamic_anonymous_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Экземпляры анонимного типа допустимо приводить к типу dynamic
            dynamic instance = new { Name = "Alex", Age = 18 };
            Console.WriteLine(instance.Name);
            Console.WriteLine(instance.Age);

            //Delay
            Console.ReadKey();
        }
    }
}
