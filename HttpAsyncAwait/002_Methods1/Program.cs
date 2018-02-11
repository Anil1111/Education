using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Methods1
{ //Именованные аргументы методов
    class Program
    {
        static int FindDifference(int heightParametr, int widthParametr )
        {
            return heightParametr - widthParametr;
        }
        static void Main(string[] args)
        {
            //Можно вызвать методов так
            int difference = FindDifference(6, 5);

            Console.WriteLine($"Разность равна: {difference}");

            //А теперь вот так:
            int widthLocalVariable = 5;
            int heightLocalWariable = 8;
            difference = FindDifference(widthParametr: widthLocalVariable, heightParametr: heightLocalWariable);
            Console.WriteLine($"Разность равна: {difference}");

            //Delay
            Console.ReadKey();
        }
    }
}
