using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Interfaces
{
    interface IInterface1             //Базовый интерфейс принято называть узким интерфейсом!
    {
        void Method1();
    }

    interface IInterface2: IInterface1  //здесь не реализация, а НАСЛЕДОВАНИЕ АБСТРАКЦИИ! 
    {                                //Дочерний интерфейс принято называть широким интерфейсом!
        void Method2();                 //Со спецификации 3.0 возвращаемое значение НЕ ВХОДИТ в сигнатуру метода
    }
    class ConcreteClass: IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 - реализация интерфейса IInterface1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 - реализация интерфейса IInterface2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method1();
            instance.Method2();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method1();

            IInterface2 instance2 = instance as IInterface2; //тут у нас есть доступ и к Method1 и к Method2 
            instance2.Method1();                             // т.к IInterface2 наследуется от IInterface1
            instance2.Method2();

            //Delay
            Console.ReadKey();
        }
    }
}
