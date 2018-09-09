using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _009_RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите шаблон       :"); //Например: \d
                string pattern = Console.ReadLine();

                Console.WriteLine("Введите выражение    :"); //Например: 123
                string text = Console.ReadLine();

                if (Regex.IsMatch(text, pattern))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ОК.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("NO.");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
            } 
        }
    }
}
