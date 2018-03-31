using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(5,91));
            Console.WriteLine(Calculator.Subtraction(5, 91));
            Console.WriteLine(Calculator.Multiple(0, 91));
            if (Calculator.Add(5, 91) != 0)
            {
                Console.WriteLine(Calculator.Add(5, 91));
            }
            else
            {
               Console.WriteLine("На ноль делить нельзя");
            }

            //Delay
            Console.ReadKey();
        }
    }
}
