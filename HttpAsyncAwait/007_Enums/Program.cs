using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEnum digit = MyEnum.Teeeeeeeeeeen;

            Console.WriteLine($"Число {digit.ToString()}");
            
            //Enum.Format() - позволяет производить более точное форматирование за счет указания флага,
            //а так же получать имена элементов перечисления по их числовым значениям

            //Вывод в 16-ричном формате. Флаг "х" - hex (16-ричный формат)
            Console.WriteLine($"Hex значение {Enum.Format(typeof(MyEnum),MyEnum.Teeeeeeeeeeen,"x")}");

            //Вывод в 10-ричном формате. Флаг "D" - dec (10-ричный формат)
            // вместо typeof(MyEnum) использую digit.GetType()
            Console.WriteLine($"Dec значение {Enum.Format(digit.GetType(), digit, "D")}"); 

            //Вывод в строковом формате. Флаг "G" - str (Строковой формат)
            Console.WriteLine($"Str значение {Enum.Format(typeof(MyEnum), 10, "G")}");

            //Delay
            Console.ReadKey();
        }
    }
}
