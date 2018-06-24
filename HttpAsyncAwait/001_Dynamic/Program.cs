using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Dynamic
{
    //Динамические типы данных. (Локальные переменные).
    //Тип переменной меняется динамически по ходу выполнение программы и по этому они и называются данамическими.
    class Program
    {
        static void Main(string[] args)
        {
            dynamic variable = 1;
            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());

            variable = "Hello world";
            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());

            variable = DateTime.Now;
            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());

            //Delay
            Console.ReadKey();
        }
        //Не смотря на то, что C# получил динамическую типизацию, все равно 
        //РЕКОМЕНДУЕТСЯ считать строго типизированным языком.
        //Динамическая типизация будет полезна для замены механизмов рефлексии в определенных случаях.
    }
}
