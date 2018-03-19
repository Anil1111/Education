using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Наследование абстрактных классов от интерфейсов
namespace _008_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
        //Реализация метода из интерфейса в астрактном классе НЕ обязательна
        //Смотри следующий пример - его можно заместить!
        public void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в асбтрактномм классе.");
        }
    }

    class ConcreteClass : AbstractClass
    {
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
