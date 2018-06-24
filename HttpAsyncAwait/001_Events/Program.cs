using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _001_Events
{
    //Идея события пришла к нам из событийно-ориентированного програмирования.
    public delegate void EventDelegate();

    class MyClass
    {
        //ключевое слово event означает, что поля типа EventDelegate мы 
        //больше не будем называть полями. Теперь это событие.
        public event EventDelegate MyEvent = null; //Мы создаем открытое событие с именем MyEvent типа EventDelegate
        //1-я особенность слова event - В object Browser`e поигрался с удалением слова event и увидел как молния прверащается в обычное поле
        //2-Я особенность слова event - запрещено на событии извне вызывать метод Invoke
        //ГЛАВНОЕ ЗАПОМНИТЬ: если поле является событием, то это поле ТИПА КАКОГО-ТО ДЕЛЕГАТА
        public void InvokeEvent()
        {//зачем вообще делать обертку на вызов события?
            //в этом методе можно делать какие-угодно проверки и исходя из их результата либо вызывать событие - либо нет.
            //например - если меня толкает Александр - то вызывать, а если нет - то делать что-то другое(например бежать)
            //if(alexandr)
            MyEvent.Invoke();
        }
    }
    class Program
    {
        //Методы обработчики события. - это методы, которые будут вызываться автоматически тогда, когда присходит событие,
        //но если мы конечно подпишем эти методы на это событие.
        //Всю жизнь мы и нам вписываем методы обработчики на разные события.
        //ДВА ОБЬЕКТА - обьект который обрабатывает это событие(с помощью методов-обраточиков) и инициатор события(пример с толканием в плече)

        //Методы-обработчики можно как прикреплять, так и открыплять.(исключение - анонимные методы)
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

            //Присоединение обработчиков события(ПОДПИСКА НА СОБЫТИЕ)
            //неправильная подписка
            instance.MyEvent += new EventDelegate(EventHandler1);
            //правильная подписка (техника предполодения делегата была придумана для событийной модели)
            instance.MyEvent += EventHandler2;

            //ГЛАВНОЕ, чтобы код был красивым, а оптимизация - это вторично!

            Console.WriteLine(new string('-', 30));
            //Метод, который вызывает событие
            instance.InvokeEvent();
            //instance.MyEvent.Invoke(); с ключевым словом event - на работает. Если убрать - то будет работать.
            Console.WriteLine(new string('-', 30));
            //Открепляем метод - обработчик
            instance.MyEvent -= EventHandler1;

            instance.InvokeEvent();

            //Delay
            Console.ReadKey();
        }
    }
}
