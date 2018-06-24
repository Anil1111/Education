using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Dynamic_events
{
    delegate dynamic MyDelegate(dynamic sender, dynamic e);

    class MyClass
    {
        public dynamic MyEvent = default(dynamic); //динамическое поле, а не событие.

        public dynamic Method(dynamic sender, dynamic e)
        {
            MyEvent.Invoke(sender, e);
            Console.WriteLine("ааааа");
            return default(dynamic);
        }
    }
    class Program
    {
        static dynamic Handler(dynamic sender, dynamic e)
        {
            Console.WriteLine($"sender = {sender}, e = {e}");
            return default(dynamic);
        }
        static void Main(string[] args) //exeption`ов нету
        {
            dynamic my = new MyClass();
            my.MyEvent += new MyDelegate(Handler);

            my.Method("user", "mouse");
            my.MyEvent.Invoke("user", "mouse");
            //Console.WriteLine(default(dynamic)); - будет ошибка
            Console.WriteLine(default(dynamic) == null ? "Null" : "????");
            //Delay
            Console.ReadKey();
        }
    }
}
