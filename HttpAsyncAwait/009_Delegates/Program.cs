using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Delegates
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            myDelegate = delegate { Console.WriteLine("first"); }; //Лямбда метод
            myDelegate += () => { Console.WriteLine("Second"); }; //Лямбда оператор
            myDelegate += () =>  Console.WriteLine("Third");      //Лямбда выражение

            myDelegate();

            //Delay
            Console.ReadKey();
        }
    }
}
