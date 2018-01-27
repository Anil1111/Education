using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Арифметические операторы: -,+,*,/,%

            //Addition(+)
            byte summand1 = 1, summand2 = 2; //Множественное обьявление
            int sum = 0;
            sum = summand1 + summand2;
            Console.WriteLine(sum);

            //Subtraction(-)
            byte minuend = 5, subtrahend = 3;
            int difference = 0;
            difference = minuend - subtrahend;
            Console.WriteLine(difference);

            //Multiplication(*)
            byte factor1 = 2, factor2 = 3;
            int production = 0;
            production = factor1 * factor2;
            Console.WriteLine(production);

            //Division
            byte devided = 10, devision = 3;
            int quolitet = 0, remainder = 0;
            quolitet = devided / devision;
            Console.WriteLine(quolitet);

            //Remainder after division(%)
            remainder = devided % devision;
            Console.WriteLine(remainder);

            //Delay
            Console.ReadLine();

        }
    }
}
