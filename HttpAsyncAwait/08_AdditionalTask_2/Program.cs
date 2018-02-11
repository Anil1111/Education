using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_AdditionalTask_2
{
    class Program
    {
        static void TurnValuesIntoSomething(double valueForDivision,ref double valueEnteredFirst, ref double valueEnteredSecond,
            ref double valueEnteredThird)
        {
            valueEnteredFirst /= valueForDivision;
            valueEnteredSecond /= valueForDivision;
            valueEnteredThird /= valueForDivision;
            Console.WriteLine($"Числа которые были вычисленны {valueEnteredFirst},{valueEnteredSecond},{valueEnteredThird}");
        }

        static void GetValuesForCalculation(out double valueEnteredFirst, out double valueEnteredSecond, out double valueEnteredThird)
        {
            Console.WriteLine("Введите число");
            valueEnteredFirst = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
             valueEnteredSecond = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            valueEnteredThird = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Числа которые Вы ввели {valueEnteredFirst},{valueEnteredSecond},{valueEnteredThird}");
        }
        static void Main(string[] args)
        {
            const double valueForDivision = 5;
            GetValuesForCalculation(out double valueEnteredFirst, out double valueEnteredSecond, out double valueEnteredThird);
            TurnValuesIntoSomething(valueForDivision, ref valueEnteredFirst, ref valueEnteredSecond, ref valueEnteredThird);

            //Delay
            Console.ReadLine();
        }
    }
}
