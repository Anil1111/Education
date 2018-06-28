using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BinaryLiterals
{
    /// <summary>
    /// В C# теперь можно использовать целочисленные типы проинициализированны бинарными литералами
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0b1, 0b10, 0b100, 0b100_____0, 0b1_0_0_0_0 };

            foreach (var number in numbers)
            {
                Console.WriteLine($"Число : {number}");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
