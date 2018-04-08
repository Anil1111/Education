using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Boxing
{
    class Program
    {
        public interface IInterface
        {
            void Method();
        }

        struct MyStruct : IInterface // если структура не будет реализовывать этот интерфейс,
        {//то мы не сможем к нему BOX'иться.
            public void Method()
            {
                Console.WriteLine("Method");
            }
        }
        static void Main(string[] args)
        {
            MyStruct instance;
            Console.WriteLine(instance.GetHashCode()); //HashCod'ы ОДИНАКОВЫ
            instance.Method();

            //Упаковка Boxing
            IInterface boxed = instance;
            Console.WriteLine(boxed.GetHashCode());   //HashCod'ы ОДИНАКОВЫ
            boxed.Method();

            //Распаковка UnBoxing
            MyStruct unBoxed = (MyStruct)boxed;
            Console.WriteLine(unBoxed.GetHashCode());  //HashCod'ы ОДИНАКОВЫ
            unBoxed.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
