using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Анонимные (лямбда) методы
//Анонимные метода => методы БЕЗ имени и НЕ принадлежащие никакому классу.
namespace _005_Delegates
//КЛЮЧЕВОЕ СЛОВО delegate используется в двух случаях: 
//1.когда мы создаем класс - делегат
//2.кога мы создаем анонимный метод
{
    //Создаем класс - делегата
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляра класса- делегата MyDelegate и сообщаем с ним анонимный метод.

            MyDelegate myDelegate1 = new MyDelegate(delegate {Console.WriteLine("Hello World"); });

            //ТЕХНИКА ПРЕДПОЛОЖЕНИЯ ДЕЛЕГАТА! Точно то же самое, что и 2мя строчками выше.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello World"); };

            //Вызов анонимного метода, СООБЩЕННОГО с делегатом
            myDelegate1.Invoke();
            myDelegate();

            //Delay
            Console.ReadKey();
        }
    }
}
