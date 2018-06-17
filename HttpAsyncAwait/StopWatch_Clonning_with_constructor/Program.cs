using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch_Clonning_with_constructor
{
    //Клонирование с использованием конструктора
    class MyClass : ICloneable
    {
        private int a, b;

        public MyClass() //задержки сделали умышленно, но в реальной жизни оно так и будет.
        {
            Thread.Sleep(1000);
            this.a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            this.b = new Random().Next(1, 100);
        }
        public object Clone()
        {
            return new MyClass();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch(); //говорят, что Stopwatch точнее, чем DateTime

            //Замер времени построения оригинала
            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine($"original построен за {timer.Elapsed.Ticks}");

            timer.Reset();

            //Замер времени построения клона
            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine($"clone построен за {timer.Elapsed.Ticks}");
            //В реальной жизни, при клонировании с помощью конструктора, некоторые данные, которые нужны для построения
            // экземпляра могут быть запрощены из сервисов удаленных, а это трата лишнего времене+ нестабильность. 
            // MemberwiseClone такого не делает. MemberwiseClone осуществляет копирования ЧЕРЕЗ ДАМП!(копирует байты из одной области памяти в другую)

            //Delay
            Console.ReadKey();
        }
    }
}
