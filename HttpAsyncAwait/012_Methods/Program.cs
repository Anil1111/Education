using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Methods
{
    class Program
    {
        //Параметр, передаваемый ПО ЗНАЧЕНИЮ(НЕ ПО ССЫЛКЕ), уничтожается при возврате значения методом
        static void AddTwo(int a)
        {
            a += 2;
            Console.WriteLine($"Значение int a = {a}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            //Принимаем ввод от пользователя и преобразуем его в целочисленное значение
            string number = Console.ReadLine();
            int result = Int32.Parse(number);
            Console.WriteLine($"Значение result = {result}");

            //В качестве аргумента передается не сама переменная result, а ЕЕ КОПИЯ!!
            AddTwo(result);
            Console.WriteLine($"Значение result {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
