using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime someData= new DateTime(2018, 8,9); // есть еще много перегрузок этого конструктора.
            TimeSpan left = someData - today;

            Console.WriteLine($"Осталось {left} дней.");


            //Если название месяца на русском - то ошибки нету!
            Console.WriteLine(DateTime.Parse("02 may 2012"));
            Console.WriteLine(DateTime.Parse("02/12/2012"));
            Console.WriteLine(DateTime.Now.ToString("ddd mmm MMM DDD yyy"));
            //Delay
            Console.ReadKey();
        }
    }
}
