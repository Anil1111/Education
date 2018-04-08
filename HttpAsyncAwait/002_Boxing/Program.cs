using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Boxing
{
    struct MyStruct //:ValueType - неявно наследуется от ValueType 
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
            MyStruct instance; // или можно так MyStruct instance = new MyStruct();

            //Упаковка (Boxing)
            ValueType boxed = instance;

            //Распаковка обьекта (UnBoxing)
            MyStruct unboxed = (MyStruct) boxed;

            //Delay
            Console.ReadKey();

        }
    }
}
