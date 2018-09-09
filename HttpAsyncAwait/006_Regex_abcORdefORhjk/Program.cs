using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _006_Regex_abcORdefORhjk
{
    class Program
    {
        static void Main(string[] args)
        {
            // | - символ указания вариантов шаблона (ИЛИ)
            string pattern = "test|str|aaaa";

            var array = new string[4];
            array[0] = "some text with test in it";
            array[1] = "some text with str in it";
            array[2] = "some text with aaaa in it";
            array[3] = "some text with nothing in it";

            var regex = new Regex(pattern);

            foreach (var element in array)
            {
                if (regex.IsMatch(element))
                {
                    Console.WriteLine($@"Строка ""{element}"" соответствует шаблону ""{pattern}");
                }
                else
                {
                    Console.WriteLine($@"Строка ""{element}"" НЕ соответствует шаблону ""{pattern}");
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
