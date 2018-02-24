using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
    //Создаем класс с именем MyClass
    //В теле класса создаем открытое поле типа string с имене field и метод с именем Method.
    public class MyClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Создаем  экземпляр класса МуСlass (по сильной ссылке).
            // 2.Создаем экземпляр класса MyClass с именем instance.
            // 3.Инстанцируем класс MyClass.
            // 4.Создаем переменную с именем instance, типа MyClass и присваиваем ей адрес экземпляра на куче.
            // (instance - является ссылкой на экзампляр класса MyClass построенный на куче)

            MyClass instance = new MyClass();

            //Полю field, экземпляра instance, присваиваем значение Hello World!
            instance.field = "Hello World";

            //Выводим на экран значение поля field экземпляра instance.
            Console.WriteLine(instance.field);

            //Вызов метода с именем Methgod на экземпляре instance.
            instance.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
