using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_LINQ_extend_methods
{
    //ВОЗМОЖНОСТЬ РАСШИРЕНИЯ LINQ
    public static class MySet
    {
        //Мы повторили сингатуры оригинальных методов Where и Select
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("Вызвана собственная реализация Where.");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<R> Select<T, R>(this IEnumerable<T> source, Func<T, R> selector)
        {
            Console.WriteLine("Вызвана собственная реализация Select");
            return System.Linq.Enumerable.Select(source, selector);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            //Неважно какой синтаксис LINQ использовать, но если создать static clas и в нем повторить сигнатуры методов LINQ,
            //то будут вызываться методы из того класса.

            //query - переменная ЗАПРОСА , //number - переменная ДИАПАЗОНА, 
            //var query = from number in numbers
            //where number % 2 == 0
            // select number * 2;

            //query - переменная ЗАПРОСА , //number - переменная ДИАПАЗОНА, 
            var query = numbers.Where(number => number % 2 == 0).Select(number => number * 2);

            //item - переменная ИТЕРАЦИИ,  
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
