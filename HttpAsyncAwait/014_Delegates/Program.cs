using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Рекурсия в лямбда операторах
namespace _014_Delegates
{
    delegate void MyDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            //Требуется отдельное присвоение ссылки на делегат с сообщенным лямбда оператором,
            //в месте создания переменной, недопустимо сразу создавать лямбда оператор.(это значит, что НЕЛЬЗЯ было сразу 
            //взять и MyDelegate myDelegate = (int i) => {...........};(Ниже пример)

            //Так нельзя делать!
            //MyDelegate myDelegate1 = (int i) =>
            //{
            //    i--;
            //    Console.WriteLine($"Begin {i}");
            //    if (i > 0)
            //    {//Рекурсия
            //        myDelegate1.Invoke(i);
            //    }
            //    Console.WriteLine($"End {i}");

            MyDelegate myDelegate = null; //Делегаты - представители ссылочного типа

            myDelegate = (int i) =>
            {
                i--;
                Console.WriteLine($"Begin {i}");
                if (i > 0)
                {//Рекурсия
                    myDelegate.Invoke(i);
                }
                Console.WriteLine($"End {i}");
            };

            myDelegate(3);

            //Delay
            Console.ReadKey();
        }
    }
}
