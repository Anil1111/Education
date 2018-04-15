using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Delegates
{
    //Не статический класс, метод которого БУДЕТ СООБЩЕН С ДЕЛЕГАТОМ
    class MyClass
    {
        //Создаем статический метод, который планируем сообщить с делегатом.
        public void Method()
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
            MyClass instance = new MyClass();
            var myDelegate = new MyDelegate(instance.Method); //Создаем экземпляр делегата и СООБЩАЕМ с ним метод.(2)
            myDelegate.Invoke(); //Вызываем метод, сообщенный с делегатом.(3)
            myDelegate();  //Другой способ вызова метода, сообщенного с делегатом.

            //Delay
            Console.ReadKey();
        }
    }

    //MyDelegate =>от MulticastDelegate =>от Delegate => от Object, ICloneable, ISerializable
    //благодаря классу MulticastDelegate мы можем делать комбинированные делегаты.
}
