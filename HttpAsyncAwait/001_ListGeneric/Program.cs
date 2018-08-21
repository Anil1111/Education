using System;
using System.Collections.Generic;
using System.Linq;

namespace _001_ListGeneric
{
    class MyReverseComparer<T> : Comparer<T>
    {
        public override int Compare(T x, T y)
        {
            return y.GetHashCode() - x.GetHashCode();
        }
    }

    //Сортировка списка
    static class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 1, 2, 3 };
            var reverseComparer = new MyReverseComparer<int>();

            int number = intList[0];
            Console.WriteLine("Original List");
            intList.PrintList();


            Console.WriteLine("a. Sort(Comparison<T> comparison)");
            intList.Sort(new Comparison<int>((x, y) => y - x)); //сообщаем с делегатом лямбда выражение

            PrintList(intList);

            Console.WriteLine("b. Sort(IComparer<T> comparer)");
            intList.Sort(reverseComparer);

            intList.PrintList();

            Console.WriteLine("c. Strict sort by using LINQ OrderBy(Func<int, int> keySelector) extension");
            var newList = intList.OrderBy(value => value);

            PrintList(newList);
            PrintList(intList);

            //Delay
            Console.ReadKey();
        }

        private static void PrintList<T>(this IEnumerable<T> intList)
        {
            foreach (T i in intList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 5));
        }
    }
}
