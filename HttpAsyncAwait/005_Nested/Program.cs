using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Nested
{
    public class MyClass : BaseClass
    {
        public void MethodFromMyClass()
        {
            Console.WriteLine("Метод MyClass класса");
        }
        public class Nested // Наследование от BaseClass не распространяется
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Метод Nested класса");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MethodFromBase(); //из MyClass не видно методов Nested
            instance.MethodFromMyClass();

            MyClass.Nested instance2 = new MyClass.Nested();
            instance2.MethodFromNested();  //из Nested не видно методов MyClass
            //instance2.MethodFromMyClass

            //Delay
            Console.ReadKey();
        }
    }
}
