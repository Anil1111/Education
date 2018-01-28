using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = "Hello, ";
            Console.WriteLine("Введите имя");

            string login = Console.ReadLine();
            // Можно ставить скобки (login == "Admin") , а можно нет. Но с ними понятнее
            @string += (login == "Admin") ? "Administrator" : "User";

            Console.WriteLine(@string);

            //Delay
            Console.ReadKey();
        }
    }
}
