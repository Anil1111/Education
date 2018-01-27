using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_CheckedUnChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // Комбинация проверки и запрета проверки переполнения.
            sbyte a = 126;
            sbyte b = 127;

            //Проверять переполнение.
            checked
            {
                a++;
                //Не проверять переполнение.
                unchecked
                {
                    b++; // Не проверят ТОЛЬКО b
                }
                a++; // тут ошибка т.к 127+1 = 128. Если мы подставим это а++ в локальную область к b
                     // там, где не проверяется, то никакой ошибки НЕ БУДЕТ!
            }
            //Delay
            Console.ReadKey();
        }
    }
}
