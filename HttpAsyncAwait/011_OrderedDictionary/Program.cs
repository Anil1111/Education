using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_OrderedDictionary
{
    // OrderedDictinary - Размещение элементо соответствует порядку их добавления в коллекцию,
    // что позволяет автоматически сохранять эементы в хронологическом порядке.
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new OrderedDictionary
            {
                {"sbishop@contoso.com", "Bishop, Scott"},
                {"chess@contoso.com", "Hell, Christian" },
                {"djump@contoso.com", "Jump, Dan" }
            };

            var firstItem = emailLookup[0]; //а в Hashtable - так нельзя сделать!

            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
