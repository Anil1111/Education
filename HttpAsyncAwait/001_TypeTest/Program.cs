using System;

namespace _001_TypeTest
{
    class MyClass
    {

    }
    class Program
    {
        //Пример получения экземпляра Type
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Type type;

            // Способы получения экземпляра класса Type.

            //1.
            type = myClass.GetType();
            Console.WriteLine($"Первый способ: {type}");

            //2.
            // Полное квалифицированное имя в строковом представлении.
            type = Type.GetType("_001_TypeTest.MyClass");
            Console.WriteLine($"Второй способ: {type}");

            //3
            type = typeof(MyClass);
            Console.WriteLine($"Третий способ: {type}");

            //4. Немного попозже

            //Delay
            Console.ReadKey();
        }
    }
}
