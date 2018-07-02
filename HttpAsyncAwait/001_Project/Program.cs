using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryA;

namespace _001_Project
{
    class MyClass : MyPublicClass
    {
        public void Method()
        {
            InternalProtectedMethod();
            PublicMethod();
            //internal метода нету.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyPublicClass instanceA = new MyPublicClass();
            instanceA.PublicMethod();
            //instanceA.InternalMethod();                  //Недоступен.
            //instanceA.InternalProtectedMethod();         //Недоступен.

            //MyInternalClass instance = new MyInternalClass(); библиотеку то мы подключили, но класс MyInternalClass не виден т.к он internal

            Console.WriteLine(new string('-', 30));

            MyClass instanceB = new MyClass(); //MyClass наследуется от MyPublicClass и у него есть InternalProtectedMethod(но его можно использовать в классе MyClass)
            instanceB.PublicMethod();
            instanceB.Method(); //внутри  метода Method есть метод InternalProtectedMethod
            //instanceA.InternalMethod();                  //Недоступен.

            //Delay
            Console.ReadKey();
        }
    }
}
