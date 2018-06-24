using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Dynamic_events
{
    //Событийная модель НЕ ПОДДЕРЖИВАЕТ динамической типизации.
    delegate dynamic MyDelegate(dynamic sender, dynamic e);

    class MyClass
    {
        private dynamic myEvent; //динамическое поле, а не событие.

        //Событие не может быть динамического типа. Оно может быть только типа делегата.
        public event MyDelegate MyEvent //public event dynamic MyEvent - нельзя так сделать
        {
            add => myEvent += value;
            remove => myEvent -= value;
        }

        public dynamic Method(dynamic sender, dynamic e)
        {
            myEvent.Invoke(sender, e);
            return default(dynamic);
        }
    }
    class Program
    {
        static dynamic Handler(dynamic sender, dynamic e)
        {
            Console.WriteLine($"sender = {sender}, e= {e}");
            return default(dynamic);
        }
        static void Main(string[] args)
        {
        }
    }
}
