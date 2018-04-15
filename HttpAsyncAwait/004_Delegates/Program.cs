using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Delegates
{
    public delegate string MyDelegate();
    class Program
    {
        public static string Method()
        {
            return "a";
        }
        public static string Method2()
        {
            return "b";
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            myDelegate = myDelegate1 + myDelegate2;
            var a = myDelegate();
            Console.WriteLine(a);
            //Delay
            Console.ReadKey();
        }
    }
}
