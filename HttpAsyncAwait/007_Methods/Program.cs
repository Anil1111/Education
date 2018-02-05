using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Methods
{
    class Program
    {
        static string Comapare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return "Comparison Less Than";
            }
            else if (value1 > value2)
            {
                return "Comarison Greater Than";
            }
            return "Comparison Equal";
        }
        static void Main(string[] args)
        {
            int operand1 = 2, operand2 = 2;
            string result = Comapare(operand1, operand2);
            Console.WriteLine(result);

            //Delay
            Console.ReadLine();
        }
    }
}
