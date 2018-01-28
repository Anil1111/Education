using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_CoffeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Предлагаем пользователю напиток
            Console.WriteLine("Размеры стаканчиков кофе: \n 1 = Маленький " +
                                                         "\n 2 = Средний" +
                                                         "\n 3 = Большой" +
                                                         "\nПожалуйста, сделайте свой выбор: ");
            //Принимаем ввод пользователя

            bool isCostSelected = false;
            int cost = 0;
            //Если оператор case имеет в своем теле код, то не поддерживается "проваливание".
            //Для организации "проваливания" можно использовать оператор безусловного перехода - goto.
            while (isCostSelected == false && cost == 0)
            {
                string coffeSize = Console.ReadLine();


                switch (coffeSize)
                {
                    case "1":
                        cost += 25;
                        isCostSelected = true;
                        break;
                    case "2":
                        cost += 25;
                        isCostSelected = true;
                        goto case "1";
                    case "3":
                        cost += 25;
                        isCostSelected = true;
                        goto case "2";
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1,2 или 3");
                        break;
                }
            }
            if (cost != 0)
            {
                Console.WriteLine($"Внесите {cost} копеек. \nСпасибо");
            }
            else
                Console.WriteLine("Пожалуйста повторите ввод");


            //Delay
            Console.ReadKey();




        }
    }
}
