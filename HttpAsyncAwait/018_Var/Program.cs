using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            //Неявно типизированные локальные переменные.
            var myVar = 7;
            Console.WriteLine(myVar);
            //НЕЯВНОТИПИЗИРОВАННЫЕ ЛОКАЛЬНЫЕ ПЕРЕМЕННЫЕ НЕ ДОПУСКАЮТ МНОЖЕСТВЕННОГО ОБЬЯВЛЕНИЯ.
            //var a = 1, b = 2, c = 3;

            //Неявнотипизированные локальные перменные ДОЛЖНЫ БЫТЬ ИНИЦИАЛИЗИРОВАНЫ.
            //var a;

            //Константа НЕ может быть неявно типизированная.
            //const var myVar = 3.14;

            //Delay
            Console.ReadKey();
        }
    }
}
