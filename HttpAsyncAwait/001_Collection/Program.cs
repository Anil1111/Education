using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Collection
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

            //Delay
            Console.ReadKey();

            //Ключевой вывод из этого примера:
            //foreach требует нестолько наследования от интерфейсов, как просто налиции правильно именованных методов.
            //Его интересует MoveNext и Current.
            //Reset Не нужен!
            //Так же foreach не хочет выполнятся без GetEnumerator.
            //Reset foreach`а не интересует.
            //foreach с помощью рефлексии проверяет наличие необходимых методов
        }
    }
}
