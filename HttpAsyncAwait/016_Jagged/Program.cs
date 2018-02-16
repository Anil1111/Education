using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedArrey = new[]
            {
                new int[] {1, 2, 3},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                new int[] {1, 2, 3, 4, 5}
            };

            //Во внешнем цикле выполняется подход ко всем вложенным массивам.
            for (int i = 0; i < jaggedArrey.Length; i++)
            {   //Во внутренем цикле выполняется обращение к каждому элементу волженного массива.
                for (int j = 0; j < jaggedArrey[i].Length; j++)
                {
                    Console.Write($"{jaggedArrey[i][j]}");
                }
                Console.Write("\n");
            }

            //Delay
            Console.ReadLine();
        }
    }
}
