using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();
            //Индексатор работает как метод Add только тогда, когда значения с таким ключем ЕЩЁ НЕТУ
            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            foreach (var name in emailLookup) 
            {
                Console.WriteLine(name); //выведет System.Collections.DictionaryEntry
            }

            Console.WriteLine(new string('-', 50));

            foreach (DictionaryEntry name  in emailLookup)
            {
                Console.WriteLine(name.Value);
            }

            Console.WriteLine(new string('-', 50));

            //У Hashtable есть свойства Keys и Values. Эти коллекции формируюутся путем прохода 
            //по каждму элементу и сбора всех Key/Value
            foreach (var name in emailLookup.Values)
            {
                Console.WriteLine(name); 
            }

            Console.WriteLine(new string('-', 50));

            foreach (var name in emailLookup.Keys)
            {
                Console.WriteLine(name);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
