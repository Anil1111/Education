using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
        //    {
        //      int a = 0;   //ОШИБКА Т.К  переменная а уже есть!
        //    }
            int a = 10, b = 2, c = -5, max;

            max = a > b ? c = a : c = b; //Сначала с=а, а только потом max = c

            Console.WriteLine(c);
            Console.WriteLine(max);

            //Delay
            Console.ReadKey();
        }
    }
}
