using System;

namespace _003_Nested
{
    class MyClass
    {
        private int field = 1;

        public class Nested
        {
            MyClass instance = new MyClass();

            public void Method(int a)
            {
                instance.field = a;
                Console.WriteLine(instance.field);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.Method(55);

            //Delay
            Console.ReadKey();
        }
    }
}
