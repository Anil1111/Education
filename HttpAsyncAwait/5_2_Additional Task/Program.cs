using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true , B = false;
            Console.WriteLine($"{A} || {B} = {A || B}");
            Console.WriteLine("!(!{0} && !{1}) = {2}", A, B, !(!A && !B));

            //Delay
            Console.ReadKey();

        }
    }
}
