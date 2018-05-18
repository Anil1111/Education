using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(2);
            list.Add(3);
            //list.Add("error");

            list.Sort();

            //list. - посмотри сколько методов там есть

            //Как создать двухмерный массив с помощью коллекций. Очень просто - ПАРАМЕТРИЗИРОВАТЬ одну коллекцию ещё одной коллекцией:
            var instance = new List<List<int>>();
            instance.Add(new List<int> { 1, 2, 3 });
            instance.Add(new List<int> { 4, 5, 6 });


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
