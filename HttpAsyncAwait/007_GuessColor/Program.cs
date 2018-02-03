using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_GuessColor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxAttemtp = 5;
            int attemt = 0;
            string color = "red";
            string exitWord = "exit";
            Console.WriteLine($"Угадайте задуманное слово с {maxAttemtp} попыток");
            Console.WriteLine($"Для выхода из программы введите {exitWord}");

            while(attemt<maxAttemtp)
            {
                Console.WriteLine($"Попытка № {++attemt}:");
                string value = Console.ReadLine();
                if (value == exitWord)
                {
                    break;
                } 
                else if (value != color)
                {
                    int attemtLeft = maxAttemtp - attemt;
                    if (attemtLeft == 0)
                    {
                        Console.WriteLine("У вас не осталось попыток, досвидания.");
                        break;
                    }  
                    else
                    {
                        Console.WriteLine($"Неправильно. Попробуйте ещё, у вас осталось {attemtLeft} попыток");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Правильно, Вы угадали слово c {attemt} попытки");
                    break;
                }
            }
            Console.WriteLine("Конец игры!");
            //Delay
            Console.ReadKey();
        }
    }
}
