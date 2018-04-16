using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Delegates
{
    delegate MyDelegate2 MyDelegate1();

    delegate void MyDelegate2();
    class Program
    {
        public static MyDelegate2 Method1()
        {
            return new MyDelegate2(Method2);  //return Method2; можно и так, ТОЛЬКО БЕЗ СКОБОК! скобок () нету!
        }

        public static void Method2()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            MyDelegate1  myDelegate1 = new MyDelegate1(Method1);
            MyDelegate2 myDelegate2 = myDelegate1.Invoke();
            myDelegate2.Invoke();

            //Delay
            Console.ReadKey();
        }
    }
}
