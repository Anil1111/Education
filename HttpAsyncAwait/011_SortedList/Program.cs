using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Когда новый элемент добавяется - происходит сортировка
            //ОТЛИЧИЕ SortedList от HashTable в том, 
            //что в HashTable элементы сортируюутся по ХЭШКОДУ, а в SortedList - по КЛЮЧУ.

            var emailLookup = new SortedList<string, string>(); //для string - не нужно реализвывать IComparable т.к SortedList
            //знает как сравнивать строки, а для того, чтобы пихать в SortedList свои типы - нужно реализовать IComparable (C# для тестировщиков)

            //ОГРАНИЧЕНИЕ: практически во всех dictionary КРОМЕ NameValueCollection мы НЕ МОЖЕМ
            //записывать значение с одинаковыми ключами.
            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            emailLookup.Add("amark@contoso.com", "Alexander Mark");

            foreach (var name in emailLookup)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 20));

            //У Hashtable, OrderedDictionary, ListDictionary, HybridDictionary - DictionaryEntry, а у SortedList - KeyValuePair
            foreach (KeyValuePair<string,string> name in emailLookup)
            {
                Console.WriteLine(name.Value);
            }
            Console.WriteLine(new string('-', 20));

            foreach (object name in emailLookup.Values)
            {
                Console.WriteLine(name);
            }
            
            //Delay
            Console.ReadKey();
        }
    }
}
