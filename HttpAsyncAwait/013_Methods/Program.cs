using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Methods
{
    class Program
    {
        //Передается ссылка на исходные аргументы, копия не создается!
        static void AddTwo(ref int a)
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

            //В качестве аргумента передается САМА переменная result!
            AddTwo( ref result);
            Console.WriteLine($"Значение result {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
