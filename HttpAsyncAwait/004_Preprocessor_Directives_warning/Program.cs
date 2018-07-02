using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Preprocessor_Directives_warning
{
    class Program
    {
        static void Main(string[] args)
        {
            //#warning позволяет создавать предупреждение из определенного места в коде.
            //Посмотреть окно ошибок, вкладка - Предупреждения.

#warning Пользовательское предупреждение.
            Console.WriteLine("Hello world");

            //Delay
            Console.ReadKey();
        }
    }
}
