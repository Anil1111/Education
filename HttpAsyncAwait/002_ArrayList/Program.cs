using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add("Hello");
            list.Add("Goodbye");

            //1.
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //2.
            IEnumerator enumerator = list.GetEnumerator();
            Console.WriteLine(enumerator.GetType()); //Вывело System.Collections.ArrayList + ArrayListEnumeratorSimple
            while (enumerator.MoveNext()) //метода MoveNext нету в ArrayList. он как-то хитро создается(рефлексия)
            {
                Console.WriteLine(enumerator.Current);
            }

            //3.  item - переменная итерации
            foreach (var item in list)
            {
                //Never do this! Добавлять тоже нельзя. Будет System.InvalidOperationException
                //list.Add(item + "12345");
                //list.Remove(item); //foreaech постоянно проверяет коллекцию на длину
                Console.WriteLine(item);

                //Вообще, коллекции в которые можно добавлять и удалять - есть.
            }

            //Delay
            Console.ReadKey();
        }
    }
}
