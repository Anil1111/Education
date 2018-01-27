using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_UnCkecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрет проверки переполнения (unchecked)
            sbyte a = 127;
            //Проверять переполнение.
            unchecked //Стоит по умолчанию!
            {
                a++; //Логическая ошибка
            }
            //127 + 1=-128
            Console.WriteLine(a);

            //Delay
            Console.ReadKey();
        }
    }
}
