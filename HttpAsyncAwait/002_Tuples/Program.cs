using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Tuples
{
    //Добавляем Manage Nuget -> Browse -> System.ValueTuple
    /// <summary>
    /// Кортеж это структура данных, с заданным количеством и порядком следования полей.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0b1, 0b10, 0b100, 0b100_____0, 0b1_0_0_0_0 };
            //Локальная функция!
            (int count, int) Tuples(IEnumerable<int> list)
            {
                var r = (s: 0, c: 0); //интересная инициализация

                foreach (var v in list)
                {
                    r.s = v;
                    r.c++;
                }

                return r;
            }

            var t = Tuples(numbers);

            Console.WriteLine($"Count {t.count}, Sum {t.Item2}");

            //Delay
            Console.ReadKey();
        }
    }
}
