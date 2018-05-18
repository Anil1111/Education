using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Constraint
{
    //where T : class - Аргумент типа должен иметь ссылочный тип, это также распространяется на тип любого класса, интерфейса, делагата или массива.
    class MyClass<T> where T : class
    {
        public T variable;
    }
    //where T : class - Аргумент должен иметь тип значения. Допускается указание любого типа значения, кроме Nullable.
    class MyClass2<T> where T : struct 
    {
        public T variable;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> instance = new MyClass<string>();
            //MyClass<int> instance2 = new MyClass<int>(); //Ошибка. int - структурный тип!

            MyClass2<int> instance3 = new MyClass2<int>();
            //MyClass2<string> instance4 = new MyClass2<string>(); Ошибка. string - ccылочный тип.

            //Delay
            Console.ReadKey();
        }
    }
}
