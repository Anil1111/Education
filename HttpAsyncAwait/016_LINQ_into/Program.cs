using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_LINQ_into
{
    //into - подобно let, позволяет определить локальный по отношению к запросу идентификатор
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Построить запрос.
            //Разделение чисел на четные и нечетные
            var query = from number in numbers
                        group number by number % 2 into partition //раскидывает по partition`ам в зависимости от результата  number % 2
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };

            var query2 = numbers.GroupBy(number => number % 2)
                .Select(partition => new { Key = partition.Key, Count = partition.Count(), Group = partition });

            foreach (var item in query)
            {
                Console.WriteLine($"mod2 == {item.Key}");
                Console.WriteLine($"Count == {item.Count}");

                foreach (var number in item.Group)
                {
                    Console.Write($"{number}, ");
                }
                Console.WriteLine("\n");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
