using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Methods
{
    class Program
    {   //В программировании, методы, что возвращают логическое значение (bool) 
                           //принято сленгово называть ПРЕДИКАТАМИ
        static bool And (bool a, bool b)
        {
            return a && b; //здесь мы возвращаем возвращаемое 
            //значение оператора КОНЬЮНКЦИЯ,производимое над 2 операндами a и b - (коньюнктами)
        }
        static void Main(string[] args)
        {
            bool operand1 = true, operand2 = false;
            bool result = And(operand1, operand2);
            Console.WriteLine($"{operand1} && {operand2} = {result}");

            //Delay
            Console.ReadKey();
        }
    }
}
