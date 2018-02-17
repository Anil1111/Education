using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task1
{
    class Program
    {
        private static readonly Random rnd;

        static Program()
        {
            rnd= new Random();
        }
       
        private static int[] CreateMassive()
        {
            Console.WriteLine("Enter the amount of massive elements");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = rnd.Next(-10, 10);
                Console.Write($"{array[i]} ");
            }

            return array;
        }

        private static void ShowSumAndAvarangeValue(int[] array)
        {
            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }
            Console.WriteLine($"\nThe sum of all elements is {arraySum}");
            Console.WriteLine($"The avarage value in this massive is {arraySum / array.Length}");
        }
        private static void ShowValueLessThanZero(int[] array)
        {
            Console.WriteLine("Now there will be the list of elements which can be divided into 2 with remainder");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2!=0)
                    Console.Write($"{array[i]} ");
            }
        }

        private static void ShowTheBiigestAndTheLeastValues(int[] array)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
                if (max < array[i])
                    max = array[i];
            }
            Console.WriteLine($"\nThe least value is {min}");
            Console.WriteLine($"The biggest value is {max}");
        }

        static void Main(string[] args)
        {

            int[] array = CreateMassive();
            ShowSumAndAvarangeValue(array);
            ShowValueLessThanZero(array);
            ShowTheBiigestAndTheLeastValues(array);

            //Delay
            Console.ReadKey();
        }


    }
}
