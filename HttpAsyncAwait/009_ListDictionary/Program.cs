using System;
using System.Collections;
using System.Collections.Specialized;


namespace _009_ListDictionary
{
    // Большой словарь - Hashtable, маленький словарь - ListDictionary
    // ListDictionary подходит для хранения небольшого количества элементов,
    // поскольку организованпо принципу обычного массива
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new ListDictionary();

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
