using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Nested
{
    class MyClass
    {
        public class NestedClass
        {
            public void Method()
            {
                Console.WriteLine("Method from Nested Class");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Указывает весь путь вложенности через точку  MyClass.NestedClass
            MyClass.NestedClass instance = new MyClass.NestedClass();
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
