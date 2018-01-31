using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Логические операции.
            //Например:
            //Чтобы проверить условие А<x<B, нельзя записать его в условном операторе непосредственно,
            //так как каждая операция отношения должна иметь два операнда.
            //Правильный способ записи: if(A < x && x < B).

            int A = 0, B = 5, x = 3;

            if(A<x && x<B)
            {
                Console.WriteLine($"Число {x} находится в диапазоне чисел от {A} до {B}");
            }
            else
            {
                Console.WriteLine($"Число {x} не попадает в диапазон чисел от {A} до  {B}");
            }

            //Delay
            Console.ReadKey();
            
        }
    }
}
