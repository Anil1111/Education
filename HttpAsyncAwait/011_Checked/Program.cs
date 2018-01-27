using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверка переполнения - (checked)
            sbyte a = 127;
            //Проверить переполнение.
            checked
            {
                a++; // ОШИБКА уровня компилятора
            }
            //127 +1 = -128
            Console.WriteLine(a);

            //Delay
            Console.ReadLine();
        }
    }
}
