using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Recursion
{
    class Program
    {//Нахожждение наибольшего делителя двух целых чисел
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Calculate(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение наибольшего общего делителя двух целых чисел");
            int a = 15, b = 33;
            Console.WriteLine($"a={a}, b={b} ,НОД = {Calculate(a,b)}");
            Console.ReadKey();
        }

        #region Второй вариант решения
        static int Calculate2(int a, int b)
        {
            while (b!=0)
                b = a % (a = b);
            return a;
        }
        #endregion
    }
}
