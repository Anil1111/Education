using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Структуры. Наследование.
// От структур нельзя наследоваться! они по умолчанию Sealed, так же как и статические классы!
namespace _003_Inheritance3
{
    struct MyStruct
    {
        //Структуры не могут иметь protected челенов
        //protected int field;
    }

    //class MyClass:MyStruct
    //{
        
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("От структур НЕЛЬЗЯ наследоваться.");
        }
    }
}
