using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_TwoDimensional
{
    class Program
    {//Массивы (двухмерный массив)
        static void Main(string[] args)
        {
            //Компилятор определяет размер массива на основаннии выражения инициализации.
            int[,] arrayForExample = {
                                      {1,2,3 },
                                      {4,5,6 },
                                      {7,8,9 }
                                     };
            Console.WriteLine(arrayForExample);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arrayForExample[i,j]}");
                }
                Console.Write("\n");
            }


            //Delay
            Console.ReadKey();
        }
    }
}
