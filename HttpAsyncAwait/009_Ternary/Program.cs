using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //double b = 1.0;
            //int max;

            //max = a > b ? a : b; //ОШИБКА!

            // 1 способ
            {
                int a = 5;
                double b = 1.0;
                double max;  // меняем int на double

                max = a > b ? a : b;
                Console.WriteLine(max);
            }
            // 2 способ
            {
                int a = 5;
                double b = 1.0;
                int max;

                max = (int)(a > b ? a : b);  // используем оператор явного приведения типа на все
                Console.WriteLine(max);      // выражение тернарного оператора
            }
            // 3 способ
            {
                int a = 5;
                double b = 1.0;
                int max;

                max = (a > b ? a : (int)b);  // используем оператор явного приведения типа только
                Console.WriteLine(max);      // на переменную b т.к только она double, а переменная max - int.
            }

            //Delay
            Console.ReadKey();

        }
    }
}
