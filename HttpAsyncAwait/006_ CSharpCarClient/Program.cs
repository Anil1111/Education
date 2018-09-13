//Нужно проверить, можем ли мы использовать в другом проект dll, которая получилась из проекта 005_Assembly_Car_dll_Library

using System;

//Для этого подключим dll`ку в References и импортируем пространство имен!
using _005_Assembly_CarLibrary;

namespace _006__CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем автомобиль спортивной модели.
            SportsCar sportsCar = new SportsCar("Jaguar", 240, 40);
            sportsCar.Acceleration();

            //Создаем мини-вэн
            MiniVan miniVan = new MiniVan();
            miniVan.Acceleration();

            //Delay
            Console.ReadKey();

            //А ВОТ И ПРИМЕР МНОГОФАЙЛОВОЙ СБОРКИ! Посмотри в C:\education\Education\HttpAsyncAwait\006_ CSharpCarClient\bin\Debug\ - а там есть dll`ка,
            //которую мы подключили. Т.е лежит exe`шник, который нам сделал компилятор и лежит dll`ка, на которую этот .exe`шник ссылается
        }
    }
}
