using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Method1
{
    class Program
    {//Рекурсия(простая рекурсия)
        //В теле метода Recursion на 24 строчке рекурсивно вызывается метод Recursion.
        //Простая рекурсия - вызов методом самого себя (самовызов). При каждом вызове строится новая копия метода.

        static void Recursion(int counter)
        {
            counter--;
            Console.WriteLine($"Первая половина метода {counter}");
            if (counter != 0)
                Recursion(counter);
            Console.WriteLine($"Вторая половина метода {counter}");
        }
        static void Main(string[] args)
        {
            Recursion(3);

            //Delay
            Console.ReadKey();
        }

    }
}
