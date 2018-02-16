using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Jagged
{
    class Program
    {//Зубчастые массивы (Jagged Array)
        static void Main(string[] args)
        {
            int [][] jaggedArrey= new int[3][];

            jaggedArrey[0]=new int[]{1,2};
            jaggedArrey[1]=new int[]{1,2,3,4,5};
            jaggedArrey[2]=new int[]{1,2,3};

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
