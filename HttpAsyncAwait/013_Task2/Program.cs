using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Matrix instance;
            for (int i = 0; i < 40; i++)
            {
                instance = new Matrix(i * 2, true);
                new Thread(instance.Move).Start();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
