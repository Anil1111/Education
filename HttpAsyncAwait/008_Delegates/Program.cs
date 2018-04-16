using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Лямбда выражения и лямбда операторы.
namespace _008_Delegates
{
    public delegate int MyDelegate(int a);

    public delegate void MyDelegate1(int a);
    class Program
    {   //Лямбда выражение - то однооператорный лямбда оператор.
        //Лямбда оператор МНОГО операторное лямбда выражение.
        //Суть: в лямбда выражении может быть ТОЛЬКО ОДИН оператор.
        //A в лямбда операторе - много операторов.
        //Например:
        //myDelegate = (x) => {Console.WriteLine("aa); return x * 2; }; //Лямбда-Оператор т.к тут 2 оператора.
        static void Main(string[] args)
        {
            MyDelegate myDelegate;

            myDelegate = delegate (int x) { return x * 2; }; //Лямбда-Метод
            //Знак => читается как "Входит". x входит в тело метода.
            myDelegate = (x) => { return x * 2; }; //Лямбда-Оператор
            //      приниает   возвращает
            myDelegate = x => x * 2; // Лямбда -Выражение.

            MyDelegate1 myDelegate1;
            //тут не получится
            myDelegate1 = delegate (int i) { i++; };

            var result = myDelegate(4);
            Console.WriteLine(result);

            //Delay
            Console.ReadKey();
        }

        //Парадигмы функционального программирования: ЗАМЫКАНИЕ, МЕМОИЗАЦИЯ, КАРРИРОВАНИЕ.
    }
}
