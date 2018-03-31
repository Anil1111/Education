using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Nested
{
    public class MyClass
    {
        public class NestedClass : BaseClass // если NestedClass public а BaseClass private - будет ошибка(так нельзя неследоваться)
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Method from Nested class");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            //  instance. методов не видно - MyClass не видит методов NestedClass //видео урок 31.
            MyClass.NestedClass instance2 = new MyClass.NestedClass();
            instance2.MethodFromBase();
            instance2.MethodFromNested();

            //Delay
            Console.ReadKey();
        }
    }
}
