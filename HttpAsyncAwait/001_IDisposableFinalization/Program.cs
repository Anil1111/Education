using System;

//IDisposable.Dispose() - как альтернатива Деструктору.
namespace _001_IDisposableFinalization
{
    //Реализация IDisposable
    public class MyClass : IDisposable
    {
        //Пользователь объекта должен вызвать этот метод
        //перед завершением работы с объектом.
        public void Dispose()
        {
            //Освобождение неуправляемых ресурсов и других содержащихся объектов
            //(Например закрытие соединение с базой данных).
            Console.WriteLine("Метод Dispose() отработал:" + this.GetHashCode());
            //Thread.Sleep(2000);
        }

        public void SomeMethod() => Console.WriteLine("Some work");

        //Деструктор, который не сработает, ибо будет исключение и до конструктора не дойдет очередь
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
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            try
            {
                instance.SomeMethod();
            }
            finally
            {
                if (instance is IDisposable && instance != null)
                {
                    instance.Dispose();
                }
            }
            //конструкция try-finally вшита в конструкцию using() так что Dispose(); выполнится даже если будет исключение

            Console.WriteLine(new string('_', 30));

            // При использовании конструкции using:
            // Dispose() вызывается автоматически при выходе за пределы области видимости using.
            // Если возникает исключение внутри блока using, то Dispose() ГАРАНТИРОВАНО ВЫЗОВЕТСЯ!
            // При компиляции этого кода, компилятор автоматически генерирует блоки try и finally.

            using (instance = new MyClass())
            {
                instance.SomeMethod();

                throw new Exception();
            } //finally {instance.Dispose();}

            //Выполняйся через Ctrl + F5
        }
    }
}
