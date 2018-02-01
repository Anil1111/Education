using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число лет стажа");
            int x = Convert.ToInt32(Console.ReadLine());
            int salary = 2000;

            if (x>0 && x < 5)
                Console.WriteLine($"Премия составляет 10 % от заработной платы {salary}. Зарплата {salary*1.1}");
            else if (x >= 5 && x < 10)
                Console.WriteLine($"Премия составляет 15 % от заработной платы {salary}. Зарплата {salary * 1.15}");
            else if (x >= 10 && x < 15)
                Console.WriteLine($"Премия составляет 25 % от заработной платы {salary}. Зарплата {salary * 1.25}");
            else if (x >= 15 && x < 20)
                Console.WriteLine($"Премия составляет 35 % от заработной платы {salary}. Зарплата {salary * 1.35}");
            else if (x >= 20 && x < 25)
                Console.WriteLine($"Премия составляет 45 % от заработной платы {salary}. Зарплата {salary * 1.45}");
            else if (x >= 25)
                Console.WriteLine($"Премия составляет 50 % от заработной платы {salary}. Зарплата {salary * 1.5}");
            else
                Console.WriteLine("Вы ввели неверное значение");

            //Delay
            Console.ReadKey();
        }
    }
}
