using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ICollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            Console.WriteLine("Count: " + collection.Count);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));

            GenericICollection<int> collection2 = new GenericICollection<int> { 1, 2, 3 }; //блок инициализатора можно использовать т.к есть метод Add
            collection2.Add(4);
            collection2.Add(5);

            collection2.Remove(4);

            foreach (var item in collection2)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
