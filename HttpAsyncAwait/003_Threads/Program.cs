using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_Threads
{
    class Program
    {
        //СТЕК ВЫДЕЛЯЕТСЯ НЕ МЕТОДУ, А ПОТОКУ.
        static void WriteSecond()
        {
            //Thread.CurrentThread - возвращает ссылку на экземпляр текущего потока.
            Thread thread = Thread.CurrentThread;

            //Присваиваем имя
            thread.Name = "Secondary";

            //Выводим на экран информация о текущем потоке.
            Console.WriteLine($"ID потока {thread.Name}: {thread.GetHashCode()}");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" ".PadRight(15) + thread.Name + " " + i);
                //Приостанавливаем выполнение текущзего потока:
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            //Получаем ссылку на экземпляр текущего потока.
            Thread thread = Thread.CurrentThread;

            //Присваиваем имя
            thread.Name = "Primary";

            //Выводим на экран информация о текущем потоке.
            Console.WriteLine($"ID потока {thread.Name}: {thread.GetHashCode()}");

            //Запускам асинхронно метод WriteSecond
            Thread secondaryThread = new Thread(WriteSecond);//ЭТА операция ЗАНИМАЕТ ВРЕМЯ и это нужно учитывать всегда!
            secondaryThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(thread.Name + " " + i);
                //Приостанавливаем выполнение текущзего потока:
                Thread.Sleep(1500);
            }
        }
    }
}
