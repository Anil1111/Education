using System;
using System.Diagnostics;
using System.Runtime;
using System.Threading;

//Серверный GC рекомендуется вызывать на серверной стороне.

// Серверный (параллельный) GC используется при наличии истинной многозадачности,
// для организации которой требуется многоядерный процессор.

// Папеллельный GC является эффективным при работе с объектами у которых имеется деструктор,
// для работы объектов без деструктора прироста в производительности не наблюдается!
namespace _006_ServerGC
{
    class MyClass
    {
        // Для тестирования требуется закомментировать деструктор.
        //~MyClass() => Thread.Sleep(10000); //10 сек, но он не будет выполняться
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Для включения серверного (параллельного) GC
            // требуется в AppConfig добавить теги:
            // <runtime><gcServer enabled ="true"/></runtime>  //потом попробуй с false
            Console.WriteLine("Приложение обслуживает серверный (параллельный) GC = " + GCSettings.IsServerGC);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 10000000; i++)
            {
                new MyClass();
            }
            timer.Stop();

            Console.WriteLine(timer.ElapsedMilliseconds);

            //gcServer enabled ="true"  - 1029 мс   с деструктором ~MyClass()
            //gcServer enabled ="false"  - 4788 мс  с деструктором ~MyClass()

            //gcServer enabled ="true"  - 126 мс   БЕЗ деструктора ~MyClass() (закомментировали ~MyClass())
            //gcServer enabled ="false"  - 57 мс    БЕЗ деструктора ~MyClass() закомментировали ~MyClass())

            //!!!Итог этого примера: если у нас есть диструктор, который работает долго - есть смысл переключаться на работу параллельного GC
            //Если же конструктор очень короткий или же его нету вообще - то переключаться смысла нету и нужно использовать обычный Garbage Collector
        }
    }
}
