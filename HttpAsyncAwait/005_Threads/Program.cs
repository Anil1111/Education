using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; //Это локальная переменная метода Main. Из анонимного метода ниже мы доступаемся к этой переменной.
            //Это и есть первая парадигма функционального программирования - ЗАМЫКАНИЕ(Closure).

            // ThreadStart
            Thread thread = new Thread(delegate () { Console.WriteLine($"1. counter = {++counter}"); });
            thread.Start();
            Thread.Sleep(5); //попробуй закоментить и посмотри на результат. Этот Sleep нужен чтобы создался поток и мы в его запустили
            //и в анонимном методе мы изменили counter
            Console.WriteLine($"2. counter = {counter}");

            // ParametrizedThreadStart
            thread = new Thread(arg => Console.WriteLine($"3. counter = {(int)arg}")); //Запускам анонимный метод асинхронно.
            thread.Start(counter);

            //Delay
            Console.ReadKey();
            //Лямбда оператор - это МНОГООПЕРАТОРНОЕ лямбда выражение.
            //Лямбда выражение - ОДНООПЕРАТОРНЫЙ лямбда оператор.
        }
    }
}
