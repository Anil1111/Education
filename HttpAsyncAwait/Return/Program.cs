using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void MessageShow()
        {
            for (int i =1; i <10;i++)
            {
                if (i==5)
                {
                    return;
                }
                Console.WriteLine(i + "Hello");
            }
        }
        static void Main(string[] args)
        {
            MessageShow();

            //Delay
            Console.ReadKey();
        }
    }
}
