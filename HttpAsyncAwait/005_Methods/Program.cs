using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Methods
{
    class Program
    {   /// <summary>
        /// Сложение двух целых чисел
        /// </summary>
        /// <param name="summand1">Первое слогаемое</param>
        /// <param name="summand2">Второе слогаемое</param>
        /// <returns>Сумма</returns>
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }
        static void Main(string[] args)
        {
            int number1 = 2, number2 = 3;
            int sum = Add(number1, number2);
            Console.WriteLine($"{number1} + {number2} = {sum}");

            //Delay
            Console.ReadKey();
        }
    }
}
