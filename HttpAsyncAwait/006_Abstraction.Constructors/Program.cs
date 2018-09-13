using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _006_Abstraction.Constructors
{
    abstract class AbstractClass
    {
        //Конструктор отрабатывает первым
        protected AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");
            //Вызывается реализация метода из производного класса - ConcreteClass
            AbstractMethod();
            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        private string s = "FIRST";
        //Конструктор отрабатывает вторым
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine($"Реализация метода AbstractMethod() в ConcreteClass {s}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            Console.WriteLine(new string('-', 55));
            instance.AbstractMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
