using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Generics
{
    //На строке создаем класс- делегата с именем MyDelegate, параметризированный двумя Указателями Места Заполнения типом T и R.
    //Метод, который будет сообщен с экземпляром данного класса-делегата, будет принимать один агрумент, типа Указателя Места Заполнения типом T
    //и возвращать значение типа Указателя Места Заполнения Типом - R.
    delegate R MyDelegate<T, R>(T argument);
    class Program
    {
        //Создадим разные методы:
        static int Add(int argument)
        {
            return ++argument;
        }

        static string Concatenate(string name)
        {
            return string.Concat("Hello ", name, "!");
        }
        static void Main(string[] args)
        {
            var myDelegate = new MyDelegate<int, int>(Add);
            int a = myDelegate.Invoke(1);
            Console.WriteLine(a);

            MyDelegate<string, string> myDelegate2 = Concatenate;
            var ss = myDelegate2.Invoke("Roman");
            Console.WriteLine(ss);

            //Delay
            Console.ReadKey();
        }
    }
}
