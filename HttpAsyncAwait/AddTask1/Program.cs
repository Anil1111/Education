using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddTask1
{
    class Program
    {
        static int deep;

        public static void Recursion()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} say \"Hello\"");
            Thread.Sleep(1000);
            Thread thread = new Thread(Recursion);
            deep++;
            thread.Name = "Thread" + deep;
            thread.Start();
        }
        static void Main()
        {
            Thread thread = new Thread(Recursion) { Name = "Thread" + deep };
            thread.Start();

            //Delay
            Console.ReadKey();
        }
    }
}
