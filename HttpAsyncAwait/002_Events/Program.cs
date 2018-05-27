using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Events
{
    public delegate void EventDelegate();

    public class MyClass
    {
        private EventDelegate myEvent;
        public event EventDelegate MyEvent
        {
            add { myEvent += value; }  // как свойство. можна ставить разные проверки
            remove { myEvent -= value; } // и тут тоже  - пример с гипнотизером и мамой, которая пытается открепить обработчик "дружбы с Васькой"
        }

        public void InvokeEvent()
        {
            this.myEvent.Invoke(); //обрати внимание на то, ЧТО мы вызываем - myEvent,а в прошлом примере было MyEvent
        }
    }
    class Program
    {
        static void EventHandler1()
        {
            Console.WriteLine("event handler1");
        }

        static void EventHandler2()
        {
            Console.WriteLine("event handler2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.MyEvent += EventHandler1;
            instance.MyEvent += EventHandler2;
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 50));

            instance.MyEvent -= EventHandler1;
            instance.InvokeEvent();

            //Delay
            Console.ReadKey();
        }
    }
}
