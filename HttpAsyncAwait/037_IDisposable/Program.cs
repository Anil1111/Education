using System;

namespace _037_IDisposable
{
    //Освобождение ресурсов - очень важный пункт и очень важная штука.

    //Реализация IDisposable
    public class MyClass : IDisposable
    {
        //Пользователь объекта должен вызвать этот метод перед завершением работы с этим объектом.
        public void Dispose()
        {
            // Освобождение неуправляемых ресурсов.
            // Освобождение других содержащихся объектов.
            // Например закрытие соединения с базой данных.
            Console.WriteLine("Метод Dispose() отработал:" + this.GetHashCode());
        }

        //Деструктор
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
    class Program
    {
        //По факту, мы сами решаем как освобождать ресурсы.
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            if (instance is IDisposable)
            {
                instance.Dispose();
            }

            Console.WriteLine(new string('_', 30));

            // Dispose() вызывается автоматически при выходе за пределы области видимости using.
            // Если возникает исключение внутри блока using, то Dispose() гарантировано вызовется.
            using (instance = new MyClass())
            {
                //Использование instance
            }

            //и конструкция using - это тоже самое(преобразуется при компиляции), что и:
            try
            {
                //Использование instance
            }
            finally
            {
                instance.Dispose();
            }


            //Что плохо??? То, что я могу вызвать метод Dispose() много раз. 
            //Нужно быть очень внимательным и использовать специальный ПАТТЕРН Disposable Pattern
            //Delay
            Console.ReadKey();
        }
    }
}
