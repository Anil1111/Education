using System;

// Шаблон Microsoft для освобождения ресурсов.
// Данный паттерн гарантирует, что пользователь,
// сможет многократно вызывать метод Dispose();
//
// Т.е это некая защита от многократного вызова метода Dispose().
// Это важно потому, что лишние вызовы метода Dispose() могут привести к лишним исключениям

namespace _002_FinalizationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 10; i++)
            {
                my.Dispose(); //т.е проверка на многократное использование метода Dispose зашита ВНУТРИ метода Dispose()
            }
        }
    }
}
