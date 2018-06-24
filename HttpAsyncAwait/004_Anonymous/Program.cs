using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Anonymous
{//Анонимные типы слабая ссылка.
    class MyClass
    {
        public int field;
        public void Method() => Console.WriteLine(field);
    }
    class Program
    {
        static void Main(string[] args)
        {
            new
            {
                My = new MyClass { field = 1 }
            }.My.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
