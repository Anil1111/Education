using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Наследование интерфейса от интерфейса, у которых совпадают имена членов.
namespace _006_Interfaces
{
    interface IInterface1
    {
        void Method();   //ПО УМОЛЧАНИЮ PUBLIC!!!
    }

    interface IInterface2 : IInterface1
    {
        //Без new  - ошибки не будет, но будет предупреждение компилятора
        new void Method();         //ПО УМОЛЧАНИЮ PUBLIC!!!
    }

    class ConcreteClass : IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface1");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            // instance.         ----Ничего не видно

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();//один метод //ОН ВИДЕН ПОТОМУ, ЧТО ВСЕ МЕТОДЫ В ИНТЕРФЕЙСАХ ПО УМОЛЧАНИЮ PUBLIC!!!

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();
            instance2.Method();//другой метод  //ОН ВИДЕН ПОТОМУ, ЧТО ВСЕ МЕТОДЫ В ИНТЕРФЕЙСАХ ПО УМОЛЧАНИЮ PUBLIC!!!

            //Delay
            Console.ReadKey();
        }
    }
}
