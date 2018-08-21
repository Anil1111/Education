using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_QueueAndStackGens
{
    class Program
    {
        static void Main(string[] args)
        {
            var que = new Queue<string>();
            que.Enqueue("Hello");
            string queued = que.Dequeue();

            var serials = new Stack<double>();
            serials.Push(1);
            double serialNumber = serials.Pop();

            //Delay
            Console.ReadKey();
        }
    }
}
