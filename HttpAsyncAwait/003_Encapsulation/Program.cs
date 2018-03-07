using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Encapsulation
{
    class MyClass
    {//Обьект не может скрывать (инкапсулировать) ничего от другого обьекта того же класса
        private MyClass my = null;
        private void Method()
        {
            Console.WriteLine("private method");
        }

        public void CallMethod()
        {
          my = new MyClass();
            //private метод виден на экемпляре, хотя и без экзампляра виден хз почему
            my.Method();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            //my.Method();  //Недопустимо!

            //Delay
            Console.ReadKey();
        }
    }
}
