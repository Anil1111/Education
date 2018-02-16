using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Array
{//Массивы (одноименный массив)
    class Program
    {
        static void Main(string[] args)
        {
            //На 15 строке создаем массив целочисленных элементов с именем array размерностью в 5 элементов
            //в блоке инициализатора заполняем его значениями 1,2,3,4,5
            int[] array = new int[5] {1,2,3,4,5};
            //Вывод на экран значений элементов массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
