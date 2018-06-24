using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _010_LINQ_Select
{
    //Select - (Операция проекции) используется для производства конечного результата запроса
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, };

            //Строиз запрос
            var query = from x in numbers
                        select new { Input = x, Output = x * 2 };

            var query2 = numbers.Select(x => new { Input = x, Output = x * 2 });

            foreach (var item in query)
            {
                Console.WriteLine($"Input = {item.Input}, \tOutput = {item.Output}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
