using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_ForInFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цикл for в цикле for. (Построение квадрата из звездочек)
            for (int counter = 0; counter<=10;counter++)
            {
               //Выводим одну строку из 10 звездочек
                for(int counterSecond=0;counterSecond<=10;counterSecond++)
                // если треугольник, то counterSecond<=counter
                {
                    Console.Write("*");
                }
                //Переход на новую строку
                Console.Write("\n"); // или просто Console.WriteLine
            }
            //Delay
            Console.ReadKey();
        }
    }
}
