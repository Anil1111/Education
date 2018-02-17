using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Task2
{
    class Program
    {
        private static readonly Random rnd;

        static Program()
        {
            rnd = new Random();
        }
        private static int[] CreateMassive()
        {
            int[] array = new int[rnd.Next(5, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("\n" + new string('-', 30));
            return array;
        }
        private static int[] ReverseTheMassive(int[] massive)
        {
            int[] reversedMassive = new int[massive.Length];
            for (int i = 0; i < massive.Length; i++)
            {
                reversedMassive[i] = massive[massive.Length - i - 1];
                Console.Write($"{reversedMassive[i]} ");
            }
            Console.WriteLine("\n" + new string('-', 30));
            return reversedMassive;
        }

        private static int[] CreateSubArray(int[] massive, int index, int count)
        {
            int[] subArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (index + i <= massive.Length - 1)
                {
                    subArray[i] = massive[index + i];
                }
                else
                {
                    subArray[i] = 1;
                }
                Console.Write($"{subArray[i]} ");
            }

            return subArray;
        }
        static void Main(string[] args)
        {
            int[] massive = CreateMassive();
            int[] reversedMassive = ReverseTheMassive(massive);
            int index = rnd.Next(1, 10), count = rnd.Next(1, 10);
            CreateSubArray(reversedMassive, index, count);

            //Delay
            Console.ReadKey();
        }
    }
}
