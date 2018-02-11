using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Method1
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;
            Console.WriteLine($"Первая половина метода Recursion {counter}");
            if (counter != 0)
                Method(counter);
            Console.WriteLine($"Вторая половина метода Recirsion {counter}");
        }

        static void Method(int counter)
        {
            Console.WriteLine($"Первая половина метода Method {counter}");
            Recursion(counter);
            Console.WriteLine($"Первая половина метода Method {counter}");
        }
        static void Main(string[] args)
        {
            Method(3);

            //Delay
            Console.ReadKey();
        }
    }
}
