using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Dynamic_calculator_example
{
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(2,3));
            Console.WriteLine(calculator.Add("1", 2));
            Console.WriteLine(calculator.Add(2.0, 3.14f)); // 2.0 - по умолчанию double,  3.14f - flout

            //Delay
            Console.ReadKey();
        }
    }
}
