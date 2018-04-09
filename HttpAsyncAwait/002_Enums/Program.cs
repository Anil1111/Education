using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Перечисления.
// Все перечисления в C# происмходят от единого БАЗОВОГО класса System.Emun
namespace _002_Enums
{
    enum MyEnum
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    enum MyEnum1 //не инициализирую специально
    {
        Zero,
        One ,
        Two,
        Three 
    }

    class Program
    {
        static void Main(string[] args)
        {          
            Enum one = MyEnum.One;
            Console.WriteLine(one);

            MyEnum digit = MyEnum.Zero;
            Enum zero = digit;
            Console.WriteLine(zero);

            Console.WriteLine(new string('-', 30));

            for (MyEnum number = MyEnum.Zero; number <= MyEnum.Three; number++)
            {
                Console.WriteLine(number);
                Console.WriteLine((byte)number);
            }
            
            Console.WriteLine(new string('-',50));
            // щас компилятор принициализирует САМ константы в перечислении
            // он ВСЕГДА инициализирует константы СВЕРХУ ВНИЗ Т.К показано в примерах позже.
            // он никогда не проинициализириует константы нулями. Всегда будут нормальные числа
            for (MyEnum1 number = MyEnum1.Zero; number <= MyEnum1.Three; number++)
            {
                Console.WriteLine(number);
                Console.WriteLine((byte)number);
            }
            Console.WriteLine(new string('-', 50));
            

            //Delay
            Console.ReadKey();
        }
    }
}
