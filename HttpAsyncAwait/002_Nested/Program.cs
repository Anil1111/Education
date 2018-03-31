using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Nested
{
    class MyClass
    {
        private static int field = 0;

        public class Nested
        {
            public void Method(int a)
            {
                field = a;                //Из Nested Class'a можно обращаться к закрытым статическим
                Console.WriteLine(field); // полям ВНЕШНЕГО класса. т.е инкапсуляия не работает.
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.Method(5);

            //Delay
            Console.ReadKey();
        }
    }
}
