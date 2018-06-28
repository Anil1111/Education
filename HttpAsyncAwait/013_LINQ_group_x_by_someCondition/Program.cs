using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ_group_x_by_someCondition
{
    // Каждый запрос солден заканчиваться либо select`ом 
    //group - является средством для разделения ввода запроса.
    class Program
    {
        //если мы групируем по условию, то будет Key
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Строим запроса
            //Разделяем числа на четные и нечетные.
            var query = from x in numbers
                        group x by x % 3; // x % 3 может быть 0, 1, 2; попробовать вместо 3 поставить что-то другое
            
            var query2 = numbers.GroupBy(x => x % 3);
            //в query лежат 3 group
            foreach (var group in query)
            {
                Console.WriteLine($"mod{group.Key} == {group.Key}"); //Key может быть 0, 1, 2

                foreach (var number in group)
                {
                    Console.WriteLine($"{number}, ");
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
