using System;

namespace _035_LargeObjectHeap
{
    //Есть куча для больших объектов, а есть куча для маленьких объектов.
    //Если объект большой - то его двигать, передвагать из одного поколения в другое - затратная операция по времени.
    //По этому большие объекты не двигаются и находятся в отдельной куче - куче для больших объектов.
    class Program
    {
        static void Main(string[] args)
        {
            long[] obj = new long[10000000];

            Console.WriteLine(obj.ToString());

            Console.WriteLine(GC.GetGeneration(obj));
        }
    }
}
