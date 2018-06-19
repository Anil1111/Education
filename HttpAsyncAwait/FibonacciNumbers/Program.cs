using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        public static IEnumerable<long> EnumerateFibonacci()
        {
            long current = 1, previous = 0;
            while (true)
            {
                yield return current;
                long temp = previous;
                previous = current;
                current += temp;
                //Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            int count = 0;
            foreach (var number in EnumerateFibonacci())
            {
                Console.WriteLine($"number :{number}");
                if (++count >= 10)
                    break;
            }
            Console.WriteLine(new string('-', 15));

            //another way to do it:
            var fibonacciNumbers = EnumerateFibonacci().Take(10);
            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine($"number :{number}");
            }

            Console.WriteLine(new string('-', 15));
            //it is possible to form  production line (or pipeline)
            var mySequence = EnumerateFibonacci().Skip(10).Take(30);
            foreach (var number in mySequence)
            {
                Console.WriteLine($"number :{number}");
            }
            //Delay
            Console.ReadKey();
        }
    }
}
