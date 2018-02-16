using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5]; //Если мы не инициализируем - то элементам 
            //массива присваиваются значения по умолчанию - в данном случае 0.

            //Вывод на экран значений элементов массива.
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            char[] charArray = new char[5]; //Если мы не инициализируем - то элементам 
            //массива присваиваются значения по умолчанию - в данном случае '\0'.

            //Вывод на экран значений элементов массива.
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            double[] doubleArray = new double[5]; //Если мы не инициализируем - то элементам 
            //массива присваиваются значения по умолчанию - в данном случае '\0'.

            //Вывод на экран значений элементов массива.
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
