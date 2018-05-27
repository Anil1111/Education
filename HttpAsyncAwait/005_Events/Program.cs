using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Events
{
    public delegate void EventDelegate();
    interface IInterface
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClass : IInterface
    {
        public virtual event EventDelegate MyEvent;
        public virtual void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent;
        public override void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
    class Program
    {
        private static void Handler1()
        {
            Console.WriteLine("Handler1");
        }

        private static void Handler2()
        {
            Console.WriteLine("Handler2");
        }

        static void Main(string[] args)
        {
            var instance = new DerivedClass();
            //Подписка методов на событие
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            //Вызов события
            instance.InvokeEvent();
            Console.WriteLine(new string('-', 50));
            //Отписка метода от события
            instance.MyEvent -= Handler2;

            //Delay
            Console.ReadKey();
        }
    }
}
