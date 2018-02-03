using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Label:
            Console.WriteLine("Введите меньшее число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите большее число");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                Console.Clear();
                Console.WriteLine("Вы ввели неверные числа.\nПожалуйста повторите ввод");
                goto Label;
            }
            else
            {
                int sum = 0;
                for (int i = a+1;i<b;i++)
                {
                    sum += i;
                    if ((i % 2) !=0)
                        Console.WriteLine(i);
                }
                Console.WriteLine($"Cумма всех чисел, которые находятся между {a} и {b} равна {sum}");
                
            }
            //Delay
            Console.ReadKey();
        }
    }
}
