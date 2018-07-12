using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Yield
{
    class Program
    {
        static IEnumerable<int> Generator(int max)
        {
            Random rnd = new Random();
            while (true)
            {
                yield return rnd.Next(max);
            }
        }
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            foreach (var item in Generator(100).Take(10))
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
