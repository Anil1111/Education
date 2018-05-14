using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic
{
    public class MyClass
    {
        //Создаем параметризированный метод - в С# - это метод, который использует Generic
        public void Method<T>(T argument)
        {
            T variable = argument;
            Console.WriteLine(variable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Method<string>("Hello world");
            instance.Method("Привет, мир");//для компилятора и так понятно, что это строка так, что он и сам подставит нужный тип!

            //Delay
            Console.ReadKey();
        }
    }
}
