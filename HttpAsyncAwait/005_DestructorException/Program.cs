using System;

namespace _005_DestructorException
{
    //Необработанное исключение в деструкторе, приводит к остановке его работе.
    class MyClass
    {
        ~MyClass()
        {
            throw new Exception("Hi there!");

            Console.WriteLine("Succeeded!"); //даже Resharper подсказывает, что эта строка - Unreachible
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //Запускай через Ctrl + F5
        }
    }
}
