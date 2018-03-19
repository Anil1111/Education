using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces
{//Наследование от класса и интерфейса у которых СОВПАДАЮТ СОГНАТУРЫ ЧЛЕНОВ.
    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method");
        }
    }

    class DerivedClass:BaseClass,IInterface
    {
        //Реализация интерфейса не обязательна, т.к
        //сиснатуры методов в классе и в интерфейсе совпадают!!!
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //Delay
            Console.ReadKey();

        }
    }
}
