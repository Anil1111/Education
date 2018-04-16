using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Анонимные (лямбда) методы
namespace _006_Delegates
{
    public delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int summand1 = 1, summand2 = 2, sum = 0;
            //This is the same
            MyDelegate myDelegate = new MyDelegate(delegate (int a, int b) { return a + b; });
            //This is the same. Когда слово delegate есть - то знака "=>" нету, а когда слова delegate нету, то знак "=>" должен быть
            MyDelegate myDelegate1 = delegate (int a, int b) { return a + b; };
            //This is the same
            MyDelegate myDelegate3 = (a, b) => a + b;

            sum = myDelegate(summand1, summand2);

            Console.WriteLine($"{summand1} + {summand2} = {sum}");

            //Delay
            Console.ReadKey();
        }
    }
}
