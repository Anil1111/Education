using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Events
{
    public delegate void EventDelegate();
    //Астратрактными могут быть методы, свойства, индексаторы, СОБЫТИЯ.
    interface IInterface
    {
        event EventDelegate MyEvent; //Абстрактное событие
    }

    public class BaseClass : IInterface
    {
        public EventDelegate myEvent;
        public virtual event EventDelegate MyEvent //Виртуально событие
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            this.myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine($"К событию базового класса был прикреплен обработчик - {value.Method.Name}");
            }
            remove
            {
                base.MyEvent -= value;
                Console.WriteLine($"От события базового класса был откреплен обработчик - {value.Method.Name}");
            }
        }
    }
    class Program
    {
        private static void EventHandler1()
        {
            Console.WriteLine("Event handler1");
        }
        private static void EventHandler2()
        {
            Console.WriteLine("Event handler2");
        }

        static void Main(string[] args)
        {
            var instance = new DerivedClass();
            //Подписываем методы обработчики на событие
            instance.MyEvent += EventHandler1;
            instance.MyEvent += EventHandler2;
            //Вызовем событие
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 30));

            //Открепляем Handler2
            instance.MyEvent -= EventHandler2;
            //Вызовем событие
            //instance.myEvent.Invoke(); //НИКОГДА ТАК НЕ ДЕЛАТЬ!!
            instance.InvokeEvent();

            //Delay
            Console.ReadKey();
        }
    }
}
