using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Task2
{
    static class Printer
    {
        enum Colors 
        {//константы не инициазировал т.к они автоматически будт присвоены от 0 и далее
            Blue,
            Green,
            Yellow
        }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:Console.WriteLine("Введенная Вами строка будет выведена цветом " +
                                          "по умолчанию т.к Вы указали неправильный код цвета.");
                    break;
            }
            Console.WriteLine(stroka);
        }

        public static void IntroduceColors()
        {
            Console.WriteLine("Возможные цвета: ");
            for (Colors i = Colors.Blue; i <= Colors.Yellow; i++)
            {
                Console.WriteLine($"Цвет - {i} , код цвета - {(byte)i}");
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            var stroka = Console.ReadLine();
            Printer.IntroduceColors();
            Console.WriteLine("Введите код цвета.");
            var color = Convert.ToInt32(Console.ReadLine());
            Printer.Print(stroka, color);

            //Delay
            Console.ReadKey();
        }
    }
}
