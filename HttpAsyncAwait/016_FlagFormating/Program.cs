using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_FlagFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            //Флаги форматирования строк
            Console.WriteLine("C format: {0:C}", 99.9);             //Вывод в денежном формате.
            Console.WriteLine("F format: {0:##}", 99.935);          //Вывод значений с фиксорованной точностью.
            Console.WriteLine("N format: {0:N}", 99999);            //Стандартное числовое форматирование.
            Console.WriteLine("X format: {0:X}", 255);              //Вывод в шеснадцатиричном формате.
            Console.WriteLine("D format: {0:D}", 0xFF);             //Вывод в десятиричном формате.
            Console.WriteLine("E format: {0:E}", 99999);            //Вывод в эксподенциальном формате.
            Console.WriteLine("G format: {0:G}", 99.9);             //Вывод в денежном формате.
            Console.WriteLine("P format: {0:P}", 99.9);             //Вывод в процентном формате.

            //Delay
            Console.ReadLine();
        }
    }
}
