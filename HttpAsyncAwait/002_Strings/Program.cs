using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Strings
{
    //Работа с методом ToString()
    class MyClass1 { }

    class MyClass2
    {
        public override string ToString()
        {
            return "We changed to ToString()";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем несколько переменный разных типов.
            Int32 myInt = 32;
            Double myDouble = 32.32;

            MyClass1 my1 = new MyClass1();
            MyClass2 my2 = new MyClass2();

            //Демонстрация работы метода ToString().
            Console.WriteLine("Примитивные типы:");
            string s1 = String.Format("myInt = {0:x} - выводится само значение", myInt); //тут неявно будет вызываться метод ToString()
            Console.WriteLine(s1);
            Console.WriteLine("myDouble = {0} - Выводится само значение.", myDouble); //тут то же самое. можем как и писать, так и не писать ToString()

            Console.WriteLine("\nПользовательские типы:");
            Console.WriteLine("my1 = {0} - Выводится полное квалифицированное имя типа", my1); //и здесь
            Console.WriteLine("my2 = {0} - Выводится переопределенная строка", my2); //и здесь

            //Delay
            Console.ReadKey();
        }
    }
}
