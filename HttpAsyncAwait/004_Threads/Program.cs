using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Threads
{
    class Box
    {
        public string Tb = "TB";
        public string tin = "Tin";
        public string magazine = "men's health";
    }
    class Program
    {
        //Метод, которые планируется выполнять асинхронно.
        static void WriteSecond(object argument)//СУТЬ: если нужно передать много параметров сюда, то передай обьект,
        {//в котором есть нужные свойства.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(argument);
            //    Thread.Sleep(1000);
            //}
            var box = (Box)argument;
            Console.WriteLine(box.magazine);
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start(new Box());

            Thread.Sleep(500);

            //Delay
            Console.ReadKey();
        }
    }
}
