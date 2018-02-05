using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Methods
{
    class Program
    {//Методы с выходными параметрами (out)
        static int Method(out int a)
        {
            //Выходные параметры должны быть изменены в теле метода, иначе будет ошибка.
            a = 1;
            return 2;
        }
        int result2; //ВАЖНО! ЭТОЙ ПЕРЕМЕННОЙ ПРИСВАИВАЕТСЯ ЗНАЧЕНИЕ ПО УМОЛЧАНИЮ Т.К ЭТО ГЛОБАЛЬНАЯ ПЕРЕМЕННАЯ (ПОЛЕ)
        static void Main(string[] args)
        {
            int operand; //ВАЖНО! ЭТОЙ ПЕРЕМЕННОЙ НЕ ПРИСВАИВАЕТСЯ ЗНАЧЕНИЕ ПО УМОЛЧАНИЮ Т.К ЭТО ЛОКАЛЬНАЯ ПЕРЕМЕННАЯ
            //out - позволяет передавать в метод НЕПРОИНИЦИАЛИЗИРОВАННЫЕ переменные;
            //можем передавать как уже проинициализированные переменные, так и еще не проинициализированные!
            int result = Method(out operand);
            Console.WriteLine($"{operand} : {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
