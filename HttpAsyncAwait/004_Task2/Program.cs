using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Label: Console.WriteLine("Введите число от 1 до 100 включительно");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number < 0 || number > 100)
                {
                    Console.WriteLine("Вы ввели число не из диапазона от 0 до 100 включительно");
                    goto Label;
                }
                string range = (number <= 35 ? (number >= 15 ? "Диапазон от 15 до 35" : "Диапазон от 0 до 15") : (number >= 50 ?
                    "Диапазон от 50 до 100" : "Диапазон от 36 до 49"));
                Console.WriteLine(range);

                ////Delay
                //Console.ReadKey();

            }

        }
    }
}
