using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTake
{
    public static class MyEnumerable
    {
        public static IEnumerable<T> MyTake<T>(this IEnumerable<T> items, int count)
        {
            using (IEnumerator<T> enumerator = items.GetEnumerator())
            {
                for (int i = 0; i < count && enumerator.MoveNext(); i++)
                {
                    yield return enumerator.Current;
                }
            }
        }
    }
    class Program
    {
        static IEnumerable<long> GetFibonacciNumbers()
        {
            long current = 1, previous = 0;
            while (true)
            {
                yield return current;
                var temp = previous;
                previous = current;
                current += temp;
            }
        }
        static void Main(string[] args)
        {
            var mySequence = GetFibonacciNumbers().MyTake(50);

            //Delay
            Console.ReadKey();
        }
    }
}
