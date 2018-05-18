using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ConstraintTU
{
    interface IInterface { /* ........*/ }
    interface IInterface<TU> { /* ........*/ } //использование Generic`ов - один из видов перегрузки.
    class Derived : IInterface, IInterface<object> { /* .......*/}

    // where T : IInterface, IInterface<object> - Аргумент типа ДОЛЖЕН ЯВЛЯТЬСЯ ИЛИ РЕАЛИЗОВЫВАТЬ ИНТЕРФЕЙС
    //Можно установить несколько ограничений интерфейса.
    //Ограничивающий интерфейс так же может быть универсальным(Generic`ом).

    class MyClass<T> where T : IInterface, IInterface<object> { /* ......*/}
    class MyClass2<T> where T : IInterface { /* ......*/}
    class MyClass3<T> where T : IInterface<object> { /* ......*/}
    class Program
    {
        static void Main(string[] args)
        {
            //В качестве агрумента типа подходит Derived, т.к, он наследуется от обоих интерфейсов.
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my2 = new MyClass<IInterface>(); //Ошибка
            //MyClass<IInterface<object> my4 = new MyClass<IInterface<object>(); //Ошибка 

            MyClass2<IInterface> my5 = new MyClass2<IInterface>();
            MyClass2<Derived> my6 = new MyClass2<Derived>();
            //MyClass2<IInterface<object>> my77 = new MyClass2<IInterface<object>>();

            MyClass3<IInterface<object>> my7 = new MyClass3<IInterface<object>>();
            MyClass3<Derived> my8 = new MyClass3<Derived>();

        }
    }
}
