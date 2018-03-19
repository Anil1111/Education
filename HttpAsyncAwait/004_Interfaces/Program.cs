using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.Method1();
            instance.Method2();

            Console.WriteLine(new string('-',55));

            BaseClass instance0 = instance as BaseClass; //видно только методы класса BaseClass
            instance0.Method();

            IInterface1 instance1 = instance as IInterface1; //видно только методы интерфейса IInterface1
            instance1.Method1();

            IInterface2 instance2 = instance as IInterface2; //видно только методы интерфейса IInterface2
            instance2.Method2();


            //Delay
            Console.ReadKey();

        }
    }
}
