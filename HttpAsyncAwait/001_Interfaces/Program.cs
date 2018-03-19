using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Interfaces
{
    interface IInterface
    {
        void Method();  //тут не нужно писать слово abstract, и так понятно, что это абстрактный метод.
                        //так же не нужно использовать модификаторов доступа ВООБЩЕ! Эта возможность скрыта т.к это бессмысленно
                        //если я не реализую интерфейс, то будет ошибка! 
                        //все абстрактные члены в интерфейсе - public!
    }

    class MyClass:IInterface
    {
        public void Method()  //слово override я тоже не пишу
        {
            Console.WriteLine("Метод - реализация интерфейса!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IInterface instence = new MyClass();
            instence.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
