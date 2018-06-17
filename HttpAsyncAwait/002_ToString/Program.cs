using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ToString
{
    class MyClass
    {
        //Закомментировать - тогда выведется 002_ToString.MyClass - полное квалифицированное имя типа
        public override string ToString()
        {
            //return base.ToString(); - нужно запомнить. это обращения к методу ToString из базового класса
            return "Hello World";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.WriteLine(instance); // даже без ToString() вызывается
            Console.WriteLine(instance.ToString());

            //Delay
            Console.ReadKey();
        }
    }
}
