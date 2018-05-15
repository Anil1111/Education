using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            var a = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>(a);
            var t = new Random();

            for (int i = 0; i < a; i++)
            {
                list.Add(i, t.Next(100));
            }
            Console.WriteLine("Массив:");
            var massive = list.GetMyArray(); //использование расширяющего метода (ОН ДЕЛАЕТ КОПИЮ НАСТОЯЩЕГО МАССИВА)

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Длbна массива {list.Length}");

            //Delay
            Console.ReadKey();
        }
    }
}
