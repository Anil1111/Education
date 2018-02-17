using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            //Заполнение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            //Вывод на экран значений элементав массива
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine("\n"+new string('-',10));
            //Вывод на экран значений элементав массива в обратном порядке
            for (int i = array.Length-1;i>=0;i--)
            {
                Console.Write(array[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
