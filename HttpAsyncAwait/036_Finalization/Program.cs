using System;

namespace _036_Finalization
{
    //!!!!ВАЖНО!!! Любой деструктор, который мы создаем - при компиляции будет преобразован в метод Finalize.
    //И сборщик мусора вызываем метод Finalize
    public class ResourceWrapper
    {
        //!!!!вообще - финализация нужна для того, чтобы захватить неуправляемые ресурсы,
        //а для управляемых ресурсов есть интерфейс IDisposable и метод Dispose
        ~ResourceWrapper() 
        {
            Console.WriteLine("Finalize!!!!!!!!!!!!!!!!!!!!!");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ResourceWrapper resource = //Так, как имеется сильная ссылка, СРАЗУ ФИНАЛИЗАЦИЯ НЕ ПРОИСХОДИТ
            new ResourceWrapper();

            GC.Collect(); //GC не тронет resource

            Console.WriteLine("\n\nНажмите любую клавишу для завершания работы");
            Console.WriteLine("и вызова Finalize() (Деструктора) сборщиком мусора");
            Console.WriteLine("для объектов предусматривающиъ финализацию в AppDomain.");

            Console.WriteLine(resource);
            resource = null;

            //Delay
            Console.ReadKey();
        }
    }
}
