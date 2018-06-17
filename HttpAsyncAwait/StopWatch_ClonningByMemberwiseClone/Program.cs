using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch_ClonningByMemberwiseClone
{
    //Преимущество клонирования с использованием MemberwiseClone() в том, что при клонировании не вызывается конструктор,
    //а клонирование происходит через КОПИРОВАНИЕ ДАМПА ПАМЯТИ - тела оригинала.
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
            return this.MemberwiseClone(); //клонируем текущий экземпляр
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
            //Видим, что клон построился быстрее, чем original т.к при построении не используется конструктор(в нем стоят задержки),
            //а клонирование происходит через КОПИРОВАНИЕ ДАМПА ПАМЯТИ - тела оригинала.

            //Delay
            Console.ReadKey();
        }
    }
}
