using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_StaticRules
{   //Статические члены НЕ МОГУТ быть ВИРТУАЛЬНЫМИ, ПЕРЕОПРЕДЕЛЕННЫМИ следовательно АБСТРАКНТНЫМИ.
    //Статические члены ПОДДЕРЖИВАЮТ ЗАМЕЩЕНИЕ.
    abstract class BaseClass
    {
        //public static virtual void StaticMethod()
        //{
        //    Console.WriteLine("BaseClass.StaticMethod");
        //}
        public static void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }
    }

    class DerivedClass :BaseClass
    {
        //public static override void StaticMethod()
        //{
        //    Console.WriteLine("DerivedClass.StaticMethod");
        //}
        public new static void StaticMethod() //ЗЕМЕСТИЛИ СТАТИЧЕСКИЙ МЕТОД.
        {
            Console.WriteLine("DerivedClass.StaticMethod");
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            DerivedClass.StaticMethod(); //через точку доступен только один такой метод.
                                     //Т.е если заместили -> старый метод не сохраняется, а сохраняется только новый  public new virtual void StaticMethod()
            BaseClass.StaticMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
