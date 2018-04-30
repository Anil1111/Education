using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        delegate double MyDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            // приводить к double обязательно т.к  у нас дробная часть будет отбрасываться при делении int на int
            MyDelegate myDelegate = (a, b, c) =>(double)(a + b + c) / 3;
            Console.WriteLine("Введите первую цифру");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью цифру");
            var number3 = Convert.ToInt32(Console.ReadLine());

            var number4 = myDelegate(number1, number2, number3);
            Console.WriteLine($"({number1} + {number2} + {number3})/3 = {number4}");

            //Delay
            Console.ReadKey();
        }
    }
}
