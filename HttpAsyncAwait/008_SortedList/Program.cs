using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_SortedList
{
    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            // Для сортировка по убыванию.
            // Объекты, переданные для сравнения, меняются местами
            // Пишем то, что хотим и сортировка в SortedList будет пользоваться этим методов
            int result = comparer.Compare(y, x); //Тут у нас и закладывается логика, как мы хотим сотрировать: ASC или DESC(можем менять местами x и y)
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Когда новый элемент добавяется - происходит сортировка

            var sort = new SortedList(new DescendingComparer());

            //Кодовая таблица символов: код маленькой буквы а - 41h, а большой 61h, b - 42h, B- 62h, так и сверяет
            //сверются не только первые буквы, а и последующие если нужно.
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3th";
            sort["Fourth"] = "4th";
            sort["fourth"] = "44th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
