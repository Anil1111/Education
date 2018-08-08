using System;
using System.Collections;
using System.Collections.Specialized;

namespace _010_HybridDictionary
{
    //HybridDictionary - Рекомандуетс к использованию в тех слуаях, когда невозможно пределить размер коллекции.
    //Т.е сначала этот HybridDictionary будет использовать механизмы ListDictionary, а потом уже Hashtable
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new HybridDictionary();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
