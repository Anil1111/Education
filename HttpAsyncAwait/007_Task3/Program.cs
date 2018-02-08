using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Task3
{
    class Program
    {
        static int EnterTheNumber()
        {
            Console.WriteLine("Введите число");
            int number = Int32.Parse(Console.ReadLine());
            return number;
        }
        static void IsTheNumberLessThanZero(int number)
        {
             // 1001 0000 1111 0000 1111 0000 0000 1010

             // 1111 1111 1111 1111 1111 1111 1111 1111
            number = number >> 31;
            if (number == -1)
                Console.WriteLine("Число отрацательное");
            else
                Console.WriteLine("Число положительное");
        }
        static void Remander (int number)
        {
            for(int i = 1;i<=9;i++)
            {
                if (number % i == 0)
                    Console.WriteLine($"Число {number} делится без остатка на {i}");
                else
                    Console.WriteLine($"Число {number} НЕ делится без остатка на {i}");
            }
        }
        static void IsTheNumberSimple(int number)
        {
            int devider = 2;
            int reminder;

            do
            {
                reminder = number % devider;
                if (reminder != 0)
                    devider++;
            }
            while (reminder !=0);
            if (devider == number)
                Console.WriteLine($"{number} - простое число");
            else
                Console.WriteLine($"{number} не простое число");
        }

        static void Main(string[] args)
        {
            var number =EnterTheNumber();
            IsTheNumberLessThanZero(number);
            Remander(number);
            IsTheNumberSimple(number);

            //Delay
            Console.ReadKey();
        }
    }
}
