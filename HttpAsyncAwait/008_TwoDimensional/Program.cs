using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_TwoDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayExample = new int[3,3];
            //Заполнение массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayExample[i, j] = i * j + 1;
                }
            }
            //Вывод массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrayExample[i, j]);
                }
                Console.Write("\n");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
