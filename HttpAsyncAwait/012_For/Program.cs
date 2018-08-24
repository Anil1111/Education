using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Циклическая конструкция - for (цикл со счетчиком)
            //for (Инициализация счетчика итерации; Условие ; Изменение счетчика) {Тело цикла}
            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine($"Counter = {counter}");
            }
            //counter = 0 // counter не доступен за ПРЕДЕЛАМИ ЦИКЛА for



            double nominal = 1.0;
            double sum = 0.0;
            for (int i = 0; i < 10; i++)
            {
                sum += 0.1;
            }

            const double TOLERANCE = 0.00001;
            bool equals = Math.Abs(nominal - sum) < TOLERANCE;
            //------------------------------

            double sum1 = 5000000.02 - 5000000.01;
            //------------------------------

            int termA = 1000000;
            int termB = 1000000;
            int termC = termA * termB / 1000000;
            //-----------------------

            double a = 10;
            double b = 10.00000000000000000001;
            double equals1 = a + b; //20


            decimal a1 = 10;
            decimal b1 = 10.00000000000000000001M;
            decimal sym = a1 + b1;


            bool equals11 = b > (double) b1;


            int aaa = 7 / 10;
            //Delay
            Console.ReadKey();
        }
    }
}
