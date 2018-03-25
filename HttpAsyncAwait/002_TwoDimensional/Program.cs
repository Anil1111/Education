using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_TwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int [,] array = new int[3,3];

            //Заполнение массива случайными значениями
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i,j]}");
                }
                Console.WriteLine("\n");
            }

            //Delay
            Console.ReadKey();

        }
    }
}
