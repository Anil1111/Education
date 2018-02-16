using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4,5};
            //Вывод на экран значений массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
