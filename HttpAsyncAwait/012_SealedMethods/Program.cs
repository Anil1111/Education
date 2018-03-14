using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_SealedMethods
{
    class MyClassA
    {
        public virtual void Method1() { Console.WriteLine("MyClassA.Method1"); }
        public virtual void Method2() { Console.WriteLine("MyClassA.Method2"); }
    }
    class MyClassB:MyClassA
    {
        public sealed override void Method1() { Console.WriteLine("MyClassB.Method1"); }
        public override void Method2() { Console.WriteLine("MyClassB.Method2"); }
    }
    class MyClassC : MyClassB
    {
        //Попытка переопределить Method1 приводит к ошибке уровня компиляции
        //public sealed override void Method1() { Console.WriteLine("MyClassB.Method1"); }

        //Переопределить Method2 позволено
        public override void Method2() { Console.WriteLine("MyClassC.Method2"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClassA instanceA = new MyClassA();
            instanceA.Method1();
            instanceA.Method2();

            Console.WriteLine(new string('-',15));

            MyClassB instanceB = new MyClassB();
            instanceB.Method1();
            instanceB.Method2();

            Console.WriteLine(new string('-', 15));

            MyClassC instanceС = new MyClassC();
            instanceС.Method1();
            instanceС.Method2();

            //Delay
            Console.ReadKey();
        }
    }
}
