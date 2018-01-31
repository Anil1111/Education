using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_ShortLogicComputing
{
    class Program
    {
        static void Main(string[] args)
        {
            //КОРОТКОЗАМКНУТОЕ ВЫЧИСЛЕНИЕ - техника работающая по следующему принципу:
            //Если значение первого операнда в операции AND (&&) ложно, то второй операнд не вычисляется,
            //потому, что полное выражение в любом случае будет ложным.

            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;
            //Условие, которое работает с использованием техники КОРОТКОЗАМКНУТОГО ВЫЧИСЛЕНИЯ.
            //Если бы это выражеие вычислялось полностью, то операция деления во втором операнде генерировала бы
            //ошибку деления на 0.
            if ((denominator != 0) && (item/denominator)> MIN_VALUE) // Оставте один оператор &, ||, |
            {
                Console.WriteLine("Мы в блоке IF");
            }
            else
            {
                Console.WriteLine("Мы в блоке ELSE");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
