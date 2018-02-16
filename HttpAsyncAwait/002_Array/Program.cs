using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Array
{
    class Program
    {
        //Массивы (одноименный массив)
        static void Main(string[] args)
        {
            int[] array = new int[5];
            //Заполнение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            //Вывод на жкран значений элементов массива
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //Delay
            Console.ReadKey();
        }

    }
}
