using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15, b = 10;
            // На 15 строке Создаем условную конструкцию if , в условии которой проверяем: a меньше b
            if(a < b)
            {
                Console.WriteLine($"{nameof(a)} < {nameof(b)}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
