using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_CriticalSection
{
    class Program
    {
        static object locker = new object();
        //у нас в примере будет 3 потока. То что в каждом методе, который будет выполняться асинхронно есть
        //lock (locker) говорит о том, что поток не будет  "лезть без очереди". Важно, чтобы обьект блокировки был один и тот же.
        static void Method()
        {
            for (int i = 0; i < 20; i++)
            {
                lock (locker)//попробуй закомметировать
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(string.Concat(new string(' ', 10), "Secondary"));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }
        static void Method2()
        {
            for (int i = 0; i < 20; i++)
            {
                lock (locker) //попробуй закомметировать
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(string.Concat(new string(' ', 20), "Thirty"));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 45);
            var thread = new Thread(Method);
            thread.Start();

            var thread2 = new Thread(Method2);
            thread2.Start();

            for (int i = 0; i < 20; i++)
            {
                lock (locker)//критические секции в разных местах, но ОБЬЕКТ БЛОКИРОВКИ ОДИН И ТОТ ЖЕ И ЭТО ОЧЕНЬ ВАЖНО. //попробуй закомметировать
                {//телефон один
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
            //Delay
            Console.ReadKey();
        }

    }
}
