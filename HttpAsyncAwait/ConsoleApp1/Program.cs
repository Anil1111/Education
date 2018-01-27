using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 10, operand2 = 3;
            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, (double)operand1 / operand2);
            Console.WriteLine("{0} % {1} = {2}", operand1, operand2, operand1 % operand2);

            //Delay
            Console.ReadKey();
        }
    }
}
