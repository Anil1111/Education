using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Abstraction
{
    //Абстрактный класс МОЖЕТ НАСЛЕДОВАТЬСЯ ОТ КОНКРЕТНОГО КЛАССА
    //Конкретный класс А
    class ConcreteClassA
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }
    //Абстрактный класс
    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }
    //Конкретный класс В
    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClassB();
            instance.Method();
            instance.Operation();

            //Delay
            Console.ReadKey();
        }
    }
}
