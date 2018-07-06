using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new UserCollection();

            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);

            foreach (Element element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }

            Console.WriteLine(new string('-', 20));

            foreach (Element element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }

            Console.WriteLine(new string('-', 20));

            //Так работает foreach

            IEnumerator enumerator = (collection as IEnumerable).GetEnumerator();
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current as Element;
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
