﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Arrays
{
    class Program
    { //Массивы (одноименный массив)
        static void Main(string[] args)
        {
            //На 15 строке создаем массив целочисленных элементов с именем array размерностью в 5 элементов

            int[] array =new int[5];

            //На 19 строке элементу массива по индексу 0 присваиваем значение 10

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;
            
            //На 26 строке выводим на экран значение элемента массива array по индексу 0
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            //Delay
            Console.ReadKey();
        }
    }
}
