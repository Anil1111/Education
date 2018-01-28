using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_If_else_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 5;
            if (a < b)      // каскад условных операторов
                Console.WriteLine($"{nameof(a)} < {nameof(b)}");  //Ветвь 1
            else if (a > b)
                Console.WriteLine($"{nameof(a)} > {nameof(b)}");  //Ветвь 1
            else
                Console.WriteLine($"{nameof(a)} == {nameof(b)}"); //Ветвь 1

            //Delay
            Console.ReadKey();
        }
    }
}
