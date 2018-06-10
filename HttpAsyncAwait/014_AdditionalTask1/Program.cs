using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AdditionalTask1
{
    class Program
    {
        static IEnumerable GetEvenCollection(int[] array)
        {
            foreach (var number in array)
            {
                if (number % 2 == 0)
                {
                    yield return number; //помним, что yield создает nested class
                }
            }
            //if (array.Length != 0)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 2 == 0)
            //        {
            //            yield return array[i];
            //        }
            //    }
            //}
            //else
            //{
            //    yield break;
            //}
        }
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenArray = GetEvenCollection(array);
            foreach (var element in evenArray)
            {
                Console.WriteLine(element);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
