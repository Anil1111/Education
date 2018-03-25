using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ArrayMultiLim
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDim =
            {
                {{1, 2}, {3, 4}},
                {{5, 6}, {7, 8}}
            };

            //Получаем количество ПОДМАССИВОВ В Массиве - GetLength(0) - 2 подмассива
            for (int i = 0; i < threeDim.GetLength(0); i++)
            {
                //Получаем количество элементов в Подмассиве - GetLength(1) - 4 элемента в каждом подмассиве.
                for (int j = 0; j < threeDim.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.WriteLine(string.Concat(threeDim[i,j,k],","));
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(threeDim.Length); //Length == 2*2*2 => (2 колонки  {{1, 2}, {3, 4}}),(2 колонки {1, 2}), 2 элемента в каждой колонке  1, 2

            //Delay
            Console.ReadKey();
        }
    }
}
