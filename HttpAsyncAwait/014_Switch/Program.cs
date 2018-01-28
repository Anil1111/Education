using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Switch   
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели используя символы 1-2-3-4-5-6-7");
            string myDay = Console.ReadLine();

            //Конвертируем значение строковой переменной myDay в целочисленное значение
            // и записываем его в переменную с именем day типа int

            int day = Convert.ToInt32(myDay);
            switch (day)
            {
                case 1:           //ПРОВАЛИВАНИЕ
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Этот день недели - Рабочий.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Этот день недели - Выходной.");
                    break;
                default:
                    Console.WriteLine("Вы ввели несуществующий день недели.");
                    break;
            }
            //Delay
            Console.ReadKey();
        }
    }
}
