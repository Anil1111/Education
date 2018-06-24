using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Dynamic_Inheritance
{
    //Динамические элементы можно наследовать
    class MyClass
    {
        public dynamic field;

        public dynamic Method()
        {
            return this.field;
        }
    }

    class Derived:MyClass 
    { }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic instance = new Derived();

            //Динамические поля должны быть проинициазированы перед использованием.
            //Console.WriteLine(instance.Method()); //- вызывает exception
            instance.field = "Hello";
            Console.WriteLine(instance.Method());

            //Delay
            Console.ReadKey();
        }
    }
}
