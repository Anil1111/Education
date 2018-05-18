using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _003_BaseConstraint
{
    public class Base { }
    public class Derived:Base { }

    //where T : Base - Аргумент типа должен являтся или быть производным от указанного базового класса (Base).
    class MyClass<T> where T : Base
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Base> instance1 = new MyClass<Base>();
            MyClass<Derived> instance2 = new MyClass<Derived>();

            //MyClass<string> instance3 = new MyClass<string>();   //Ошибка

            //Delay
            Console.ReadKey();
        }
    }
}
