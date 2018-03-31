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
                instance.field = a;  //тут тоже инкапсуляция не работает. тут можно обращаться к закрытым нестатическим
                Console.WriteLine(instance.field);  //членам внешнего класса.
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
