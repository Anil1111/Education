using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Task2
{
    class Program
    {
       public static  (double amountOfMoney, double curse) EnterAllData(out double convertResult)
        {
            Console.WriteLine("Введите сумму денег для конвертации");
            double amountOfMoney = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите курс валюты для конвертации");
            double curse = Convert.ToDouble(Console.ReadLine());
            convertResult= amountOfMoney * curse;
            return (amountOfMoney,curse);
        }
        static void Main(string[] args)
        {
            double convertResult;
            var a = EnterAllData(out convertResult);
            Console.WriteLine($"Перевод суммы денег {a.amountOfMoney} " +
                $"по курсу {a.curse} в сумму {convertResult}");


            //Delay
            Console.ReadLine();
        }
    }
}
