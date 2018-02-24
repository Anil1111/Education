using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{//Создание экземпляра по слабой ссылке.(Анонимные обьекты)
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello World");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method(); 

            //Delay
            Console.ReadKey();
        }
    }
}
