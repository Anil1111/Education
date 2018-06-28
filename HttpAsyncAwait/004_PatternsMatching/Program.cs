using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_PatternsMatching
{
    /// <summary>
    /// Теперь в C# 7.0 можно использовать разнообразные средства для сопоставления.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            object[] numbers = {0b1, 0b10, new object[] {0b10, 0b100, 0b10_000}, 0b0001};

            (int sum, int count) Tally(IEnumerable<object> list)
            {
                var tupleVariable = (s: 0, c: 0);

                foreach (var item in list)
                {
                    if (item is int i) //используется локальная переменная i.  if (item is int i)  если это true, то в i записуется значение item
                    {
                        tupleVariable.c = i;
                        tupleVariable.s++;
                    }
                }

                return (tupleVariable);
            }

            Tally(numbers);

            //Delay
            Console.ReadKey();
        }
    }
}
