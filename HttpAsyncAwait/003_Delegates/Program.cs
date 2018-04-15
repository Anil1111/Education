using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Delegates
{
    //Не статический класс, метод которого БУДЕТ СООБЩЕН С ДЕЛЕГАТОМ
    class MyClass
    {
        //Создаем статический метод, который планируем сообщить с делегатом. 
        //Этот метод удовлетворяет требования делегата MyDelegate
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }
    //На 21 строке создаем класс- делегата с именем MyDelegate
    //метод, который будет сообщен с экземпляром данного класса- делегата,
    //должен ПРИНИМАТЬ строковой аргумент и ВОЗВРАЩАТЬ строковое значение.
    public delegate string MyDelegate(string name); //Создаем класс делегата.(1)
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            var myDelegate = new MyDelegate(instance.Method); //Создаем экземпляр делегата и СООБЩАЕМ с ним метод.(2)
            var greeting = myDelegate.Invoke("Roman Borodavka"); //переменной greeting присваиваем возвращаемое значение метода, сообщенного с делегатом.
            Console.WriteLine(greeting);
            greeting = myDelegate("Grady Booch");  //Другой способ вызова метода, сообщенного с делегатом.
            Console.WriteLine(greeting);

            //Delay
            Console.ReadKey();
        }
    }

    //MyDelegate =>от MulticastDelegate =>от Delegate => от Object, ICloneable, ISerializable
    //благодаря классу MulticastDelegate мы можем делать комбинированные делегаты.
}
