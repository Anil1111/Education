using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_CriticalSection
{
    //Пример: дети - потоки, которые получают доступ к мячу - разделяюмому ресурсу.
    //Эстафетная палочка - объект синхронизации доступа к разделяюмом ресурсу(обьект блокировки).У кого в руках находится эта палочка
    //тот и может зайти на эстефетную дорожку- критическая секция.

    //lock - блокирует блок кода так, что в каждый отдельный момент времени,ТОЛЬКО ОДИН ПОТОК сможет использоватЬ этот блок кода.
    //Все остальные потоки ждут пока текущий поток закончит работу.

    class MyClass
    {
        object blockObject = new object();//объект синхронизации доступа к разделяюмом ресурсу(обьект блокировки)
        //Консоль - разделяюемый ресурс.
        public void Method()//этот метод мы планируем запускать асинхронно
        {
            int hash = Thread.CurrentThread.GetHashCode();
            //если сделать так  lock (new object()) - то ничего работать не будет
            lock (blockObject)//КРИТИЧЕСКАЯ СЕКЦИЯ. если закоментировать эту строку, то три потока будут работать одновременно!
            {//когда поток заходит в КРИТИЧЕСКАЯ СЕКЦИЮ он записывает значение null в blockObject, а когда выходит - то возвращает на прежнее значение.
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Поток № {hash}: шаг {i}");
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
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
        //Что ещё может быть разделяемым ресурсом?
        //Например файл! Представь, что из несколких потоков одновременно начинается запись в один файл.
    }
}
