using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            // instance.   -- //На экземпляре не видим private методов интерфейсов!

            //Приведем экземпляр класса DerivedClasss - instance, к базовому интервейсному типу IInterface1
            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 interface2 = instance as IInterface2;
            interface2.Method();

            //Но мы можем увидить методы, которые public
            instance.Method3();
            //Delay
            Console.ReadKey();
        }
    }
}
