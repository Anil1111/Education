﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Делегат- это специальный обьект, который предназначен для того, чтобы хранить в себе указателИ на методы(он содержит в себе таблицу указателей на методы).
//Технически можно так сказать, но никто не увидит и не докажет этого. Делегаты нативны и написаны на неуправляемом коде.
//Сначала логические адреса => потом уже физичиские адреса.
//Например у ассива есть логические адреса 0, 1, 2. После компиляции они преобразуются в физические адреса.
namespace _001_Delegates
{
    //Статический класс, метод которого БУДЕТ СООБЩЕН С ДЕЛЕГАТОМ
    static class MyClass
    {
        //Создаем статический метод, который планируем сообщить с делегатом.
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод СООБЩЕННЫЙ с делегатом");
        }
    }
    //На 21 строке создаем класс- делегата с именем MyDelegate
    //метод, который будет сообщен с экземпляром данного класса- делегата,
    //не должен ничего принимать и не должен ничего возвращать.
    public delegate void MyDelegate(); //Создаем класс делегата.(1)
    class Program
    {
        static void Main(string[] args)
        {
            //Важно: мы не пишем () после названия метода т.е не пишем так new MyDelegate(MyClass.Method())
            //мы передаем только имя метода, а не его возваращаемое значение
            MyDelegate myDelegate = new MyDelegate(MyClass.Method); //Создаем экземпляр делегата и СООБЩАЕМ с ним метод.(2)
            myDelegate.Invoke(); //Вызываем метод, сообщенный с делегатом.(3)
            myDelegate();  //Другой способ вызова метода, сообщенного с делегатом.

            //Delay
            Console.ReadKey();
        }
    }
}
