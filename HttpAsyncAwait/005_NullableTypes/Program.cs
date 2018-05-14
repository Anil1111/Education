using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_NullableTypes
{
    class Program
    {
        public static int? aaaa;
        static void Main(string[] args)
        {
            Console.WriteLine(aaaa.HasValue); //выведет false т.к значпение по умолчанию для Nullable - это null

            Nullable<int> a = 1; //Nullable - это СТРУКТУРА GENERIC. Enum не может быть GENERIC
            if (a.HasValue == true) //HasValue - свойство, которые показывает, если ли значение у элемента или нету.
            {
                Console.WriteLine($"a is {a.Value}");
            }

            //Короткая нотация Nullable типа - "?", доступна ТОЛЬКО ДЛЯ С#.
            int? b = 1;
            if (b.HasValue == true)
            {
                Console.WriteLine($"b is {b.Value}");
            }

            //Неявно типизированная локальная переменная не может быть - Nullable
            //var? c = null;

            //Delay
            Console.ReadKey();
        }
    }
}
