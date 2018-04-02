using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры. Наследование.

// Наследование структур разрешено ТОЛЬКО ОТ ИНТЕРФЕЙСОВ!
// Наследование структур от классов и структур - ЗАПРЕЩЕНО!
namespace _001_Inheritance1
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct: IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct instance;
            instance.Method();

            //Delay
            Console.ReadKey();

        }
    }
}
