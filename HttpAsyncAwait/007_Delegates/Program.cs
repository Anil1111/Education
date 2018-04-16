using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Delegates
{
    public delegate void MyDelegate(ref int a, ref int b, out int c);

    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum;
            //анонимный метод, который я сообщаю с делегатом принимает (ref int a, ref int b, out int c) и имеет тело { a++; b++; c = a + b;}
            MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b;};

            myDelegate.Invoke(ref summand1,ref summand2, out sum);

            Console.WriteLine($"{summand1} + {summand2} = {sum}");

            //Delay
            Console.ReadKey();

        }
    }
}
