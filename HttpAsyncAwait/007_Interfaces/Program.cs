using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Interfaces
{   //Наследование от интерфейсов у которых совпадают имена членов.
    //Объединение реализации одноименных абстрактных членов.
    interface IInterface1
    {
        void Method();
    }
    interface IInterface2
    {
        void Method();
    }

    class ConcreteClass: IInterface1, IInterface2
    {   //ТУТ можно использовать технику указания явного имени интерфейса в имени метода, но тогда эти два 
        //одноименных метода будут по умолчанию private и чтобы их использовать нужно будет приводиться к базовым типам.

        //void IInterface1.Method()
        //{
        //    throw new NotImplementedException();
        //}

        //void IInterface2.Method()
        //{
        //    throw new NotImplementedException();
        //}

        public void Method()  //используем ТЕХНИКУ ОБЪЕДИНЕНИЯ РЕАЛИЗАЦИИ ОДНОИМЕННЫХ АСТРАКТНЫХ ЧЛЕНОВ
                              //Этот метод будет виден ВЕЗДЕ Т.К ОН PUBLIC
        {
            Console.WriteLine("Method - реализация интерфейса IInterface1 (1-2)");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
