using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки");
            byte x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);
            //                                       0011 0101 непарное
            // сдвигаем это число влево на 7 позиций 1000 000  ! = 0
            if(n==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }

            //Delay
            Console.ReadLine();
        }
    }
}
