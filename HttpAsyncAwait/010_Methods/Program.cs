using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Methods
{
    class Program
    {//Методы с выходными параметрами (out)
        static int Method(out int a)
        {
            //Выходные параметры должны быть изменены в теле метода, иначе будет ошибка.
            a = 2;
            return a * 2;
        }
        static void Main(string[] args)
        {
            int operand =5;
            //out - позволяет передавать в метод НЕПРОИНИЦИАЛИЗИРОВАННЫЕ переменные;
            //можем передавать как уже проинициализированные переменные, так и еще не проинициализированные!
            int result = Method(out operand);
            Console.WriteLine($"{operand} : {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
