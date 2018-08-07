using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();

            // Метод Add принимает в качестве первого переметра ключ,
            // а в качестве второго - значение
            emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");

            // Невозможно добавить элемент с уже имеющимся в хэш-таблице кючом.
            //emailLookup.Add("sbishop@contoso.com", "Bishop, Scott2"); //System.ArgumentException

            // Особенности использовани индексаторов.

            // Использовани индексатора эквивалнтно вызову Add, если такого индекса не сущевствует.
            emailLookup["s.bishop@contoso.com"] = "Bishop, Scott"; //contoso - второе название компании Microsoft

            //Если такой индекс существует, то происходит только замена знаения
            emailLookup["s.bishop@contoso.com"] = "------------";

            Console.WriteLine(emailLookup["sbishop@contoso.com"]);
            Console.WriteLine(emailLookup["s.bishop@contoso.com"]);

            //Delay
            Console.ReadKey();

            //Когда нужно использовать Hashtable?
            //Когда размер коллекции будет больше 10ти элементов.
            //Если в коллекции Hashtable меньше 10ти элементов - то это называется неоптимальным.
        }
    }
}
