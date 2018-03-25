using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5};

            array = new int[5];
            array = new int[5] {1, 2, 3, 4, 5};
            array = new int[] {1, 2, 3, 4, 5};

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
