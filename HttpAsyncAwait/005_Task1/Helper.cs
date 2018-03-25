using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Task1
{
    class MyArray
    {
        private int[] array;

        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];   //Abs - означает взять по модулю
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public void ShowMinValue()
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]); //метод Min возвращает наименьшее из ДВУХ чисел! 
            }
            Console.WriteLine($"Min value = {min}");
        }
        public void ShowMaxValue()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]); //метод Max возвращает наибольшее из ДВУХ чисел! 
            }
            Console.WriteLine($"Max value = {max}");
        }
        public int ShowAndReturnSum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; //метод Max возвращает наибольшее из ДВУХ чисел! 
            }
            Console.WriteLine($"Sum = {sum}");
            return sum;
        }

        public void ShowAvarage()
        {
            Console.WriteLine($"Average = {ShowAndReturnSum() / array.Length}");
        }

        public void Odd()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    Console.WriteLine(array[i]);
            }
        }
    }
}
