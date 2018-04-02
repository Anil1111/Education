using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Nested1
{
    struct MyStruct
    {
        public class MyClass
        {
            public void Method()
            {
                Console.WriteLine("Method from nested class");
            }
        }
    }

    class MyClass1
    {
        public struct NestedStructure
        {
            public void Method()
            {
                Console.WriteLine("Method from nested structure");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct.MyClass instance = new MyStruct.MyClass();
            instance.Method();

            MyClass1.NestedStructure instance2= new MyClass1.NestedStructure();
            instance2.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
