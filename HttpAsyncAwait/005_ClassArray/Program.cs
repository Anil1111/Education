using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ClassArray
{
    class Program
    {
        //Абстрактный класс Array
        //Все массивы являются производными от класса Array.
        //ВСЕ МАССИВЫ ЯВЛЯЮТСЯ ПРОИЗВОДНЫМИ ОТ КЛАССА ARRAY.
        static void Main(string[] args)
        {
            int[] vector = {1, 2, 3};
            Array array = vector as Array; //Создаем переменную array типа Array и 
                                           //присваиваем ей ссылку на массив vector 
                                           //где используем безопасное приведение к базовому типу

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            //Delay
            Console.ReadLine();
        }
    }
}
