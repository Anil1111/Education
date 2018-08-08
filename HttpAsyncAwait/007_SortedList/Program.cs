using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Когда новый элемент добавяется - происходит сортировка

            var sort = new SortedList();

            //Кодовая таблица символов: код маленькой буквы а - 41h, а большой 61h, b - 42h, B- 62h, так и сверяет
            //сверются не только первые буквы, а и последующие если нужно.
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3th";
            sort["Fourth"] = "4th";
            sort["fourth"] = "4th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
