using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //Операторы Инкремента и Декремента ( Increment and Decrement Operators)
            Console.WriteLine("-------- Постфиксаный инкремент"); // Post-increment
            byte number1 = 0;
            Console.WriteLine(number1++); //Сначала выводим на экран, а потом увеличиваем на 1.
            Console.WriteLine(number1);

            Console.WriteLine("-------- Префиксный инкремент "); //Pre - Increment;
            byte number2 = 0;
            Console.WriteLine(++number2); //Сначала увеличиваем на 1, а потом выводим
            Console.WriteLine(number2);

            Console.WriteLine("--------Постфиксный декремент");// Post-decrement
            sbyte number3 = 0;
            Console.WriteLine(number3--);// Сначала выводим на экран, потом уменьшаем на 1.
            Console.WriteLine(number3);

            Console.WriteLine("--------Префиксный декремент");// Pre- Decrement
            sbyte number4 = 0;
            Console.WriteLine(--number4); //Сначала уменьшаем на 1, а потом выводим на экран.
            Console.WriteLine(number4);

            //Delay
            Console.ReadLine();
        }
    }
}
