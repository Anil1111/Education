using System;
using System.Collections;

namespace _010_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable хранит свои значения в виде дерева и упорядочивает их по ХЭШУ(вызывая метод GetHashCode)
            //по этому и называется Hashtable?  Т.Е ПОРЯДОК ЭЛЕМЕНТОВ В КОТОРОМ ОНИ ДОБАВЛЯЛИСЬ НЕ БУДЕТ СОХРАНЯТЬСЯ
            //Заем нужны эти деревья? Для обеспечения более быстрого поиска и добавления
            //элементов в данную коллекцию. Hashtable - для БОЛЬШОЙ КОЛЛЕКЦИИ(больше 10 элементов.) Если очень много
            //элементов в коллекции - нужно переопределить метод GetHashCode т.к обычный алгоритм не еффективен(сказал Джефри Рихтер)

            var emailLookup = new Hashtable();
            //Индексатор работает как метод Add только тогда, когда значения с таким ключем ЕЩЁ НЕТУ
            //Если значение с таким ключем уже есть - то оно поменяется на новое.
            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            foreach (var name in emailLookup)
            {
                Console.WriteLine(name); //выведет System.Collections.DictionaryEntry
            }

            Console.WriteLine(new string('-', 50));

            //ОБРАТИ ВНИМАНИЕ! Порядок вывода будет не таким как порядок, в котором мы добавляли элементы в коллекцию
            //Почему? Потому, что значения сортирутся по ХЭШкоду.
            //У Hashtable - DictionaryEntry, а у SortedList - KeyValuePair
            foreach (DictionaryEntry name in emailLookup)
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

            //Dictionary - заменя для HashTable
            //Delay
            Console.ReadKey();
        }
    }
}
