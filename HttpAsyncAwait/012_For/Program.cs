using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Циклическая конструкция - for (цикл со счетчиком)
            //for (Инициализация счетчика итерации; Условие ; Изменение счетчика) {Тело цикла}
            for (int counter=0; counter<3; counter++)
            {
                Console.WriteLine($"Counter = {counter}");
            }
            //counter = 0 // counter не доступен за ПРЕДЕЛАМИ ЦИКЛА for

            //Delay
            Console.ReadKey();
        }
    }
}
