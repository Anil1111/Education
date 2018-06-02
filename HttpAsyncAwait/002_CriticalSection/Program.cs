using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_CriticalSection
{
    //lock - это сокращенное использование Systes.Threading.Monitor.
    //Monitor.Enter(this) - блокирует блок кода так, что его может использовать только текущий поток.
    //Все остальные потоки ждут пока текущий поток, закончит работу и вызовет Monitor.Exit(this).
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            //КРИТИЧЕСКАЯ СЕКЦИЯ - участок кода, в которо происходит попытка доступа к разделяемому ресурсу.
            Monitor.Enter(block);//это то же самое, что и lock. но лучше использовать lock т.к Monitor.Exit можно забыть
            for (int i = 0; i < 10; i++) //и тогда поток останется в петле смерти.
            {
                Console.WriteLine($"Поток № {hash}: шаг {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine(new string('-', 20));
            Monitor.Exit(block);//закоментировать - будет петля смерти
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            var instance = new MyClass();
            for (int i = 0; i < 3; i++) //запускаем 3 разных потока.
            {
                new Thread(instance.Method).Start();
            }
            Thread.Sleep(500);

            //Delay
            Console.ReadKey();
        }
    }
}
