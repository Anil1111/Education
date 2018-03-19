using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Наследование абстрактных классов от интерфейсов
namespace _009_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
       //Замещение абтрактного метода из интерфейса, в абстрактном классе.
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        //Реализация абстрактного метода из абстрактного класса, в конкретном классе обязательна.
        public override void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в асбтрактномм классе.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
