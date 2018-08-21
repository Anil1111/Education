using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_LinkedListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Идея в том, что элементы связанного списка соеденены друг с другом. И можно перейти к любому
            //элементу списка не обращаясь к самому набору. Это полезно при манипуляциях с объектами, которым нужны данные о соседях.

            //В ДАННОМ СЛУЧАЕ каждый объект класса LinkedListNode<string> содержит string и ссылку на другой объект.
            //Хороший пример - бусы или цепочка. Каждое звено - это кусочек металла(или другого материала) и у него есть ссылки на соседей.

            var links = new LinkedList<string>(); //веревочка для бус
            //У LinkedListNode<string> есть свойства List - показутся все бусы, Next - показуется следующая бусинка, Previous - предидущая.

            LinkedListNode<string> first = links.AddFirst("First"); // LinkedListNode<string> first - это ссылка на "бусинку"
            LinkedListNode<string> last = links.AddLast("Last");    // посмотри на свойства этого объекта (List, Next, Previous)
            LinkedListNode<string> afterLast = links.AddAfter(last, "After last");
            LinkedListNode<string> second = links.AddBefore(last, "Second");

            links.AddAfter(second, "Third");

            foreach (string s in links)
            {
                Console.WriteLine(s);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
