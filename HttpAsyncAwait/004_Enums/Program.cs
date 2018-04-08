using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Перечисления.
namespace _004_Enums
{
    class Program
    {
        //Enum, как аргумент метода
        public static void MethodEnum(MyEnum a)
        {
            switch (a)
            {
                case MyEnum.Zero:
                    Console.WriteLine("Число 0");
                    break;
                case MyEnum.Two:
                    Console.WriteLine("Число 2");
                    break;
                case MyEnum.Five:
                    Console.WriteLine("Число 5");
                    break;
                case MyEnum.Ten:
                    Console.WriteLine("Число 10");
                    break;

                default: break;
            }
        }
        static void Main(string[] args)
        {
            MethodEnum(MyEnum.Five);

            MyEnum digit = MyEnum.Ten;
            MethodEnum(digit);

            int i = (int)(++digit);
            Console.WriteLine(i);

            Console.WriteLine(digit); //Переменная изменилась
            Console.WriteLine((int)MyEnum.Ten); //Константа не изменилась

            digit++;
            digit += 5;

            //Недопустимо
            //digit = ++MyEnum.One;
            //digit = MyEnum.One + MyEnum.Two;

            //Delay
            Console.ReadKey();
        }
    }
}
