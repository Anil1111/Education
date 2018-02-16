using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не указываем размерность массива вообще!Система сама опеределяет
            int[] array = new int[] {1,2,3,4,5}; //  {1,2,3,4,5}  блок инициализатора

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
