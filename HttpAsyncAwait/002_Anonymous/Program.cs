using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            // Анонимные типы в анонимных типах.

            var instance = new { Name = "Alex", Age = 27, Id = new { Number = 123 } };

            Console.WriteLine($"Name = {instance.Name}, Age = {instance.Age}, Id = {instance.Id.Number}");

            //Delay
            Console.ReadKey();
        }
    }
}
