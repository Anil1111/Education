using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Delegates
{
    public delegate void MyDelegate();

    public delegate int MyDelegateInt();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            int x= 1;
            myDelegate = delegate { Console.WriteLine("first"); }; //Лямбда метод
            myDelegate += () => { Console.WriteLine("Second"); }; //Лямбда оператор
            myDelegate += () =>  Console.WriteLine("Third");      //Лямбда выражение

            MyDelegateInt myDelegateInt;
            myDelegateInt = () => x++; //выглядит точно так же как и сверху, но ПО СИГНАТУРЕ ДЕЛЕГАТА ВИДНО ЧТО 
            //возвращаемое значение int, а у MyDelegate - void. 

            myDelegate();

            //Delay
            Console.ReadKey();
        }
    }
}
