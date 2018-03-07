using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Если вы хотите произвести конвертацию В гривну введите 1 \r\n" +
                              "если же ИЗ гривны введите 2");
            var indicator = Convert.ToInt32(Console.ReadLine());
            if (indicator != 1 && indicator != 2)
            {
                Console.WriteLine("Вы ввели неправильное значение. Сделайте Ваш выбор снова");
                Console.Clear();
                goto Start;
            }

            Console.WriteLine("Введите количество валюты, которую хотите переконвертировать");
            middleLabel:
            var amountOfMoney = Convert.ToInt32(Console.ReadLine());
            if (amountOfMoney <= 0)
            {
                Console.WriteLine("Не понял, давай ещё раз");
                goto middleLabel; ;
            }
            third:
            Console.WriteLine("Введите через пробел курсы валют через запятую в формате USD,EUR,RUB\r\n" +
                              "НАПРИМЕР 25,4 30,56 0,35\r\n" +
                              "Если не хотите вводить какой-то курс, то поставьте 0");
            var courses = Console.ReadLine();
            if (courses == null)
            {
                Console.WriteLine("Дядя, соберись! Введи нормальный курс!");
                goto third;
            }
            var parsedMoneyValue = courses.Trim().Replace(".", ",").Split(' ');
            var usd = Convert.ToDouble(parsedMoneyValue[0]);
            var eur = parsedMoneyValue.Length > 1 ? Convert.ToDouble(parsedMoneyValue[1]) : 0;
            var rub = parsedMoneyValue.Length > 2 ? Convert.ToDouble(parsedMoneyValue[2]) : 0;
            var converter = new Converter(usd, eur, rub);

            if (indicator == 1)
            {
                if (usd != 0)
                    Console.WriteLine($"{amountOfMoney} долларов по курсу {converter.USD} это {amountOfMoney * converter.USD} гривен.");
                if (eur != 0)
                    Console.WriteLine($"{amountOfMoney} евро по курсу {converter.EUR} это {amountOfMoney * converter.EUR} гривен.");
                if (rub != 0)
                    Console.WriteLine($"{amountOfMoney} рублей по курсу {converter.RUB} это {amountOfMoney * converter.RUB} гривен.");
            }
            else
            {
                if (usd != 0)
                    Console.WriteLine($"{amountOfMoney} гривен по курсу {converter.USD} это {amountOfMoney / converter.USD} долларов.");
                if (eur != 0)
                    Console.WriteLine($"{amountOfMoney} гривен по курсу {converter.EUR} это {amountOfMoney / converter.EUR} евро.");
                if (rub != 0)
                    Console.WriteLine($"{amountOfMoney} гривен по курсу {converter.RUB} это {amountOfMoney / converter.RUB} рублей.");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
