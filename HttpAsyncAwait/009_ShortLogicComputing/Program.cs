using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ShortLogicComputing
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
            //Условие, которое  НЕ работает с использованием техники КОРОТКОЗАМКНУТОГО ВЫЧИСЛЕНИЯ.
            //Из-за того, ЧТО ОПЕРАЦИЯ && (And) ВЫЧИСЛЯЕТСЯ СЛЕВА НА ПРАВО, данное
            //данное логически эквивалентное выражение работать НЕ БУДЕТ!!!
            if (((item / denominator) > MIN_VALUE) && (denominator != 0)) // Оставте один оператор &
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
