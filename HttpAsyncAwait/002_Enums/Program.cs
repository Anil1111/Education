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

            //Delay
            Console.ReadKey();
        }
    }
}
