using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Перечисления. Значение по умолчанию для перечислени.
namespace _005_Enums
{
    enum MyEnum : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Переменной five типа EnumType может быть назначено любое значение, входящее в диапазон
            //базового типа(сейчас у нас byte т.к MyEnum:byte), значения не ограничены именованными константами.
            MyEnum five = (MyEnum)250;
            Console.WriteLine(five);

            //Delay
            Console.ReadKey();
        }
    }
}
