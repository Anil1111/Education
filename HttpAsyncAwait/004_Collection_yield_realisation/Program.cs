using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Collection_yield_realisation
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection_simpler<Element>();

            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);

            //foreach ищет MoveNext, Current В ИТЕРАТОРЕ
            foreach (Element element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }

            Console.WriteLine(new string('-', 20));

            foreach (Element element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
