using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Params
{
    class Program
    {
        //Ключевое слово params, позволяет определить параметр метода, принимающий переменное количество аргементов.
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
            }
        }

        static void Main(string[] args)
        {
            ShowArray(1,2,3,4,5,6,7,8);//под рефлектором система создает настоящщий массив и подставляет его в качестве аргумента метода.

            //Delay
            Console.ReadKey();
        }
    }
}
