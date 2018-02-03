using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Additional_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину прямоугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину прямоугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<a;i++)
            {
                for (int j = 0; j<b;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //Delay
            Console.ReadKey();
        }
    }
}
