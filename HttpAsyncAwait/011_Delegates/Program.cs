using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Delegates
{
    delegate MyDelegate3 Functional(MyDelegate1 myDelegate1, MyDelegate2 myDelegate2);
    delegate string MyDelegate1();
    delegate string MyDelegate2();
    delegate string MyDelegate3();
    class Program
    {//ЕСЛИ СОЗДАЕТСЯ АНОНИМНЫЙ МЕТОД, ТО нужно это ассоциировать как создание экземпляра делегата и СООБЩЕНИЯ этого метода с ним
        public static MyDelegate3 Method(MyDelegate1 myDelegate1, MyDelegate2 myDelegate2)
        {// это анонимный метод delegate { return myDelegate1.Invoke() + myDelegate2.Invoke(); };
            // это техника ПРЕДПОЛОЖЕНИЯ делагата: new MyDelegate(delegate { return myDelegate1.Invoke() + myDelegate2.Invoke(); });
            return delegate { return myDelegate1.Invoke() + myDelegate2.Invoke(); };
        }

        public static string Method1() => "Hello"; //как такую шляпу отличить от свойства? у свойства нету ()!

        public static string Method2() => "World";

        static void Main(string[] args)
        {
            Functional functional = new Functional(Method);
            MyDelegate3 myDelegate3 = functional.Invoke(new MyDelegate1(Method1), new MyDelegate2(Method2));
            //оно впихнуло анонимный метод в myDelegate3, который возвратит Hello World
            Console.WriteLine(myDelegate3.Invoke());

            //Delay
            Console.ReadKey();
        }
    }
}
