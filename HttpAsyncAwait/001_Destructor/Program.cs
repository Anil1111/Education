using System;

namespace _001_Destructor
{
    class MyClass
    {
        //Destructor (Метод Finalize)
        ~MyClass()
        {
            Console.WriteLine("Hello from Destructor!");

            //И делаем свои черные дела, например закрываем соединение с базой данных.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            //Деструктор невозможно вызвать вручную.
            //Вызывается автоматически сборщиком мусора.
            //my.~MyClass();


            //Если выполнять программу БЕЗ дебагера -> с помощью Ctrl + F5, то Console.ReadKey не нужно!
            //Будет надпись "Press any key to continue.  .  ."
        }
    }
}
