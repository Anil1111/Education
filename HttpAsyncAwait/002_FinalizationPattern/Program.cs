using System;

// Шаблон Microsoft для освобождения ресурсов.
// Данный паттерн гарантирует, что пользователь,
// сможет многократно вызывать метод CleanUp();
//
// Т.е это некая защита от многократного вызова метода CleanUp().
// Это важно потому, что лишние вызовы метода CleanUp() могут привести к лишним исключениям

namespace _002_FinalizationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 10; i++)
            {
                my.Dispose(); //т.е проверка на многократное использование метода CleanUp зашита ВНУТРИ метода CleanUp()
            }
        }
    }
}
