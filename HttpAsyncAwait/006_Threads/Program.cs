using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006_Threads
{
    //Основные и фоновые потоки. По умолчанию свойство IsBackground равно false. 
    //- т.е программа не закончит выполнятся пока все вторичные потоки не закончат свою работу.
    //если true - то когда основной поток закончит свою работу, то планировщик потов УБЪЕТ вторичный поток.
    class Program
    {
        //Метод, который планируется выполнять в отдельном потоке.
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }
        static void WriteThird()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 30) + "Thirdly");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            //Работа вторичного потока
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            Thread thread2 = new Thread(WriteThird);
            thread2.Start();

            //Работа первичного потока
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }

            //Завершить работу вторичного потока
            //background - фоновый. А логика такая - что когда основные потоки заканчивают работу, то программа закрывается
            //даже если фоновые потоки не завершили свою работу.
            thread.IsBackground = true; //- если true, то когда основной поток заканчивает свою работу
            //то программа завершается. 
            //Если false - то будет ожидаться когда вторичные потоки закончат свою работу.
            thread2.IsBackground = false; //все потоки будут ждать этот поток.
        }
    }
}
