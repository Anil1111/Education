using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Sizeof
{
    class Program
    {
        static void Main(string[] args)
        {
            //Оператор sizeof  - позволяет получить размер значения в байтах для указанного типа.
            //Оператор sizeof можно применять только к типам: 
            //byte, sbyte, short, ushort, uint, int, long, ulong, float, double, decimal, char, bool.
            //Возвращаемое оператором sizeof значения имеют тип int.

            int doubleSize = sizeof(double);
            Console.WriteLine("Размер типа double: {0} байт", doubleSize);
            Console.WriteLine("Размер типа int {0} байт", sizeof(int));
            Console.WriteLine("Размер типа bool {0} байт", sizeof(bool));
            Console.WriteLine("Размер типа long {0} байт", sizeof(long));
            Console.WriteLine("Размер типа short {0} байт", sizeof(short));

            //Delay
            Console.ReadKey();
        }
    }
}
