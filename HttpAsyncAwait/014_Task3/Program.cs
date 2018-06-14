using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Task3
{
    public static class StaticClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];
            int position = 0;
            foreach (var item in list)
            {
                array[position] = item;
                position++;
            }

            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            var array = list.GetArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
