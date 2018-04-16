using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Делегаты. (Предположение делегата)
namespace _013_Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод, сообщенный с делегатом.");
        }
    }

    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            //Точно тоже самое. Это техника предположения делегата.
            //Слово delegate мы указываем если хотим создать АНОНИМНЫЙ метод. Но в данном случаем я не создаю анонимный метод, по
            //этому я и не использую слово delegate строчкой ниже
            MyDelegate myDelegate1 = MyClass.Method;
            myDelegate1();

            //Delay
            Console.ReadKey();
        }
    }
}
