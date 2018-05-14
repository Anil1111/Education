using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //a - содержит неизвестное значение
            int? a = null;
            int? b = -5; //b = -5;

            //При сравнении операторов один из которых = null - результатом сравнения всегда будет - false.
            //Следовательно, нельзя расчитывать на истинность (правильность разультата)
            if (a >= b)
            {
                Console.WriteLine("a >= b");
            }
            else
            {
                Console.WriteLine("a < b");
            }

            //Сравнивать операнды (Nullable) ЕСТЬ смысл только для проверки оби ли содержат null?
            //и если оба операнда содержат null, то результатом сравнения будет - true.

            b = null;
            if (a == b)
            {
                Console.WriteLine("a==b");
            }
            else
            {
                Console.WriteLine("a != b");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
