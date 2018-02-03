using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int z = 1;

            ////Прямоугольник
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            ////Прямоугольный треугольник
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //(Не совсем)Равносторонний треугольник
            int buff = b;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < z; c++)
                {
                    Console.Write("*");
                }
                z += 2;
                b -= 1;
                Console.Write("\n");
            }
            //Ромб
            z = 1;
            for (int i = 0; i < (a + a + 1); i++)
            {
                if (i < a)
                {
                    for (int d = 0; d < buff; d++)
                    {
                        Console.Write(" ");
                    }
                    for (int h = 0; h < z; h++)
                    {
                        Console.Write("*");
                    }
                    buff -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int n = 0; n < buff; n++)
                    {
                        Console.Write(" ");
                    }
                    for (int m = 0; m < z; m++)
                    {
                        Console.Write("*");
                    }
                    buff += 1;
                    z -= 2;
                    Console.WriteLine();
                }
            }
            //Delay
            Console.ReadKey();
        }
        
     }

}

