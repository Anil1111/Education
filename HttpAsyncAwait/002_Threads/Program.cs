using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Threads
{
    class Program
    {
        //Зачем нужны потоки?
        //1. Пример с браузеров и загрузкой большого файла. Браузер загреивается когда файл игрузится и его нельзя использовать.
        //2. Пример выполнения ресурсоемкой задачи в несколько потоков. Почему бригада строителей состоит из многих а не из одного?
        //Так быстрее, но если потоков очень много - они будут друг-другу мешать. Если будет потоков больше, чем ПРОПУСКНАЯ СПОСОБНОСТЬ КАНАЛА - они 
        //будут друг-другу мешать.
        //На переключение между потоками затрачивается время. По этому очень важен балланс.

        static void WriteSecond()
        {
            //CLR назначает каждому потоку свой стек и методы имеют свои собственные локальные переменные.
            //ОТДЕЛЬНЫЙ ЭКЗЕМПЛЯР переменной counter создаетсяВ СТЕКЕ КАЖДОГО ПОТОКА,
            //поэтому для каждого потока выводятся, свои counter - 0,1,2.....
            int counter = 0;
            while (counter < 10)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Thread ID {Thread.CurrentThread.GetHashCode()}, counter = {counter}");
                counter++;
            }
        }
        static void Main(string[] args)
        {
            //Работа вторичного потока
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            //Работа первичного потока.
            WriteSecond();

            //Delay
            Console.ReadKey();
        }
    }
}
