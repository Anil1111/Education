using System;
using System.Threading;

namespace _003_DestructorThread
{
    //!!!!ВАЖНО. Перед удалением Garbage Collecor определяет, объекты у которых имеются деструкторы, и объекты у которых не имеются деструткоры.
    //Если у объекта НЕТУ ДИСТРУКТОРА, то такой объект СРАЗУ ЖЕ УДАЛЯЕТСЯ.
    //А те объекты, у которых ЕСТЬ ДИСТРУКТОР ПОМЕЩАЮТСЯ В СПЕЦИАЛЬНУЮ ОЧЕРЕДЬ ФИНАЛИЗАЦИИ и потом, когда у Carbage Collector`a есть свободное время, он вызывает диструктор на экземпляре.

    //Когда Garbage Collector вызывает деструктор - он его выполняет в В ОТДЕЛЬНОМ ПОТОКЕ - все диструкторы выполняются в этом одном потоке и 
    //если объектов с диструктором много, то диструкторы будут вызваны последовательно в этом отдельном потоке, который принадлежит Garbage Collector`y.
    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Destructor thread ID: {0}",
               Thread.CurrentThread.ManagedThreadId);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Метод Main выполняется в контексте первичного потока.
            Console.WriteLine($"Main thread ID: {Thread.CurrentThread.ManagedThreadId}");

            MyClass my = new MyClass();

            //Delay
            Console.ReadKey();
        }
    }
}
