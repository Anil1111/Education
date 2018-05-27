using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Event
{
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent;
        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    class Program
    {
        private static void Handler1()
        {
            Console.WriteLine("Event handler 1");
        }

        private static void Handler2()
        {
            Console.WriteLine("Event handler 2");
        }

        static void Main(string[] args)
        {
            var instance = new MyClass();
            //Подписка обработчиков событий не событие
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            //подписывает анонимный метод на событие
            instance.MyEvent += delegate { Console.WriteLine("Анонимный метод 1."); };
            //Вызов события
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 50));

            //Открепление методов - обработчиков
            instance.MyEvent -= Handler2;
            //НЕВОЗМОЖНО ОТКРЕПИТЬ ранее присоединенный анонимный метод. (на Professional посомтрим как можно это сделать)
            instance.MyEvent -= delegate { Console.WriteLine("Анонимный метод 1."); };

            instance.InvokeEvent();

            //Delay
            Console.ReadKey();
        }
    }
}
