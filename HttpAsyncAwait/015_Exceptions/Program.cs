using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типы ошибок : программные и пользовательские.
            //Програмные - ловятся компилятором
            //Пользовательские - ошибки, которые возникают из-за пользователя.
            //Исключения - возникают во время выполнения кода.

            int a = 1, n = 0,c;
            c = a / n;
            Console.WriteLine(c);

            //Delay
            Console.ReadKey();
        }
    }
}
