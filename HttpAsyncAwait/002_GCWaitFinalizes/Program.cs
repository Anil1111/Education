using System;

//Для успешной работы метода GC.WaitForPendingFinalizers()
//- требуется включить оптимизацию. //На проект(002_GCWaitFinalizes) -> ПКМ -> Properties -> Build -> check the "Optimize Code" checkbox
namespace _002_GCWaitFinalizes
{
    class MyClass
    {
        ~MyClass()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write("|");
            }

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            GC.Collect(); //посмотри на перегрузки метода Collect(). Тут MyClass my будет расценен как мусор

            //Установить комментарий - тогда Деструктор и GC будут работать параллельно(синхронно)
            GC.WaitForPendingFinalizers(); //Суть метода в том, он приостанавливает выполнение текущего потока, до тех пор пока деструктор выполнятся
            //если у меня много потоков, то нужно в каждом потоке вызывать WaitForPendingFinalizers(),чтобы каждый поток ждал пока Деструктор выполнится.

            for (int i = 0; i < 80; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}
