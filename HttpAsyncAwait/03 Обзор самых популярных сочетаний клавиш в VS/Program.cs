using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Обзор_самых_популярных_сочетаний_клавиш_в_VS
{
    class Program
    {
        //Комментирование и раскомментирование строк Ctrl+k+c Ctrl+k+v
        public static int Plus(int x, int y)
        {
            return x + y;
        }

        // Поиск Ctrl +F   след результат - Enter ; препидущий результат - shift+ enter
        // Горячие клавиши быстрой замены Ctrl + H; В интерфейсе клацаем , по одному заменяем
        // Ctrl +G  - можно переходить на любую строку
        // F5 - запуск программы с отладкой
        // Ctrl+F5 запуск программы без отладки
        //Можем ставить Breakpoint с помощью F9; чтобы убрать - также F9
        // Чтобы убрать все Breakpoint - Ctrl+ shift+ F9
        static void Main(string[] args)
        {
            int result = Plus(5, 7);
            Console.WriteLine(result);
          
            //Delay
            Console.ReadKey();
        }
    }
}
