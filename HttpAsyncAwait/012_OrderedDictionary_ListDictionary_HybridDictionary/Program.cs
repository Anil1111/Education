using System;
using System.Collections;
using System.Collections.Specialized;

namespace _012_OrderedDictionary_ListDictionary_HybridDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderedDictionary - Размеение элементов соответствует ПОРЯДКУ ИД ДОБАВЛЕНИЯ В КОЛЛЕКЦИЮ.
            //что поволяет автоматически сохранять элементы в ХРОНОЛОГИЧЕСКОМ порядке.

            var emailLookup = new OrderedDictionary
            {
                {"sbishop@contoso.com", "Bishop, Scott"},
                {"chess@contoso.com", "Hell, Christian"},
                {"djump@contoso.com", "Jump, Dan"}

            };

            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }

            //ListDictionary - Подходит для хранения НЕБОЛЬШОГО количества элементов,
            //поскольку организована по принципу обычного списка. Одна из самых медленных коллекций в DictionaryEntry

            var emailLookup2 = new ListDictionary();

            emailLookup2["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup2["chess@contoso.com"] = "Hell, Christian";
            emailLookup2["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup2)
            {
                Console.WriteLine(entry.Value);
            }

            //HybridDictionary - Рекомендуется к использованию в тех случаях, когда невозможно
            //определить размер коллекции заранее.
            //До 10 элементов - HybridDictionary работает как ListDictionary,
            //после 10 элементов HybridDictionary работает как Hashtable.
            var emailLookup3 = new HybridDictionary();

            emailLookup3["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup3["chess@contoso.com"] = "Hell, Christian";
            emailLookup3["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup3)
            {
                Console.WriteLine(entry.Value);
            }

            //Delay
            Console.ReadKey();

            //Рекомендация - использовать обычный Generic Dictionary(или коллекцию). Они проверены их
            //много кто использует. Если же они не подходят, то уже только потом обратить внимание на эти коллекции.
        }
    }
}
