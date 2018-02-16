using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Params
{//Ключевое слово params, позволяет определить параметр метода, принимающий 
 //переменное количество аргументов
    class Program
    {
        public static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void Main(string[] args)
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7);

            //Delay
            Console.ReadKey();
        }
    }
}
