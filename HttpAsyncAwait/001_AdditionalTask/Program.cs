using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_AdditionalTask
{
    //На 12й строке мы создаем класс MyClass, параметризированный параметром места заполнения типа T,
    //и с ограничением- constraint(тип T должен иметь конструктор по умолчанию.)
    //Зачем это ограничение? За тем, что оно нам ГАРАНТИРУЕТ то, что у типа T БУДЕТ КОНСТРУТКОР ПО УМОЛЧАНИЮ.
    public class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    public class Roma { }

    class Program
    {
        static void Main(string[] args)
        {
            var romaInstance = MyClass<Roma>.FactoryMethod();
            Console.WriteLine(romaInstance.GetType().Name);

            var i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i.GetType().Name);

            var programInstance = MyClass<Program>.FactoryMethod();
            Console.WriteLine(programInstance.GetType().Name);

            //Delay
            Console.ReadKey();

        }
    }
}
