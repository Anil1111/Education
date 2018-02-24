using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _009_Classes;

namespace _009_Classes
{ //Передача экземпляра класса в качестве аргумента метода
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }

    class MyClass2
    {
        //На 20 строке создаем метод с именем CallMethod, который принимает один аргумент типа MyClass
        //и ничего не возваращает
        public void CallMethod(MyClass my)
        {
            //В теле метода CallMethod, на 23 строке вызываем метод с именем Method аргумента my
            my.Method();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass2 my2 = new MyClass2();
            my2.CallMethod(my);

            //Delay
            Console.ReadKey();
        }
    }
}

