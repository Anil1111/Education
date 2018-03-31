using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Рaсширяющик методы (Extension methods) - реализует идею динамического наследования.
//Использование ref и out агрументов. (Агрумент расширения не может быть ни ref ни out.)
 //The first parameter of an extention method cannt be declared as ref or out!
namespace _005_Extentsion
{
    static class ExtensionClss
    {
        public static void Add(this int summand1, ref int summand2, out int sum)
        {
            sum = summand1 + summand2;
            Console.WriteLine($"{summand1} + {summand2} = {sum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum = 0;
            summand1.Add(ref summand2, out sum);

            //Delay
            Console.ReadKey();
        }
    }
}
