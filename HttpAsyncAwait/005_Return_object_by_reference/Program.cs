using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Return_object_by_reference
{
    /// <summary>
    /// В С# 7.0 можно получить объект по ссылке.
    /// </summary>
    class Program
    {
        private static ref int Find(int[] list, Func<int, bool> predecite)
        {
            int i;
            for (i = 0; !predecite(list[i]); i++) ;
            return ref list[i];
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };

            ref int r = ref Find(numbers, x => x > 4);

            Console.WriteLine($"{r} == {numbers[3]}");
            r = 0; //в переменной ref int r сожержится ССЫЛКА на реальный объект, по этому ниже будет 0 == 0
            Console.WriteLine($"{r} == {numbers[3]}"); //returns  0 == 0

            Console.ReadKey();
        }
    }
}
