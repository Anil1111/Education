using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Task5
{
    static class Extend
    {
        public static void SortUp(this int[] array) //сортировка по возрастанию!
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        var x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 5, 7, 0, 4, 1, 7, 9, 3, 5, 7, 8};
            array.SortUp();
            foreach(int a in array) //foreach используется для коллекций.
                Console.Write(a+" "); // массив - это тоже хитрый тип коллекций, так что
                                        // foreach тоже можно использовать с массивами!
            //Delay
            Console.ReadKey();
        }
    }
}
