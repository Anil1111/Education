using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Methods
{
    class Program
    {
        static void Add(ref int x, ref int y, out int sum)
        {
            sum = x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-е число:");
            //Принимаем ввод от пользователя и преобразуем его в целочисленное значение
            string operand1 = Console.ReadLine();
            int summand1 = Int32.Parse(operand1);

            Console.WriteLine("Введите 2-е число:");
            //Принимаем ввод от пользователя и преобразуем его в целочисленное значение
            string operand2 = Console.ReadLine();
            int summand2 = Int32.Parse(operand2);

            int sum = 0;
            Add(ref summand1, ref summand2, out sum);
            Console.WriteLine($"{summand1} + {summand2} = {sum}");

            //Delay
            Console.ReadKey();  //Тут уже все ок, но ref'ы стоят там, где они 100 лет не нужны!
                                //А с out классно придумано! Метод ничего не возварашщает, но "обновленную" сумму мы имеем.

        }
    }
}
