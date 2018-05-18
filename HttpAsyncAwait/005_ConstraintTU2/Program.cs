using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ConstraintTU2
{
    interface IInterface { }

    interface IInterface<TU> : IInterface { }
    class Derived : IInterface, IInterface<object> { /* ..... */ }
    class Derived2 : IInterface<object> { /* ..... */ }

    // where T : IInterface, IInterface<object> - Аргумент типа ДОЛЖЕН ЯВЛЯТЬСЯ ИЛИ РЕАЛИЗОВЫВАТЬ ИНТЕРФЕЙС
    //Можно установить несколько ограничений интерфейса.
    //Ограничивающий интерфейс так же может быть универсальным(Generic`ом).

    class MyClass<T> where T : IInterface, IInterface<object> { /* ...... */ }
    class MyClass2<T> where T : IInterface<object> { /* ...... */ }
    class Program
    {
        static void Main(string[] args)
        {
            // В качестве аргумента типа подходит Derived, т.к, он наследууется от обоих интерфейсов.
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my3 = new MyClass<IInterface>(); - ошибка

            //Аргумент типа подходит, т.к <IInterface<object> наследуется от IInterface
            MyClass<IInterface<object>> my2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> my3 = new MyClass2<Derived>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> my5 = new MyClass2<IInterface<object>>();

            //Delay
            Console.ReadKey();
        }
    }
}
