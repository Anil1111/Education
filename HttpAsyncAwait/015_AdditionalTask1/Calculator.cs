using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AdditionalTask1
{
    class Calculator
    {
        public double Add(double arg1, double ard2) => arg1 + ard2;

        public double Sub(double arg1, double arg2) => arg1 - arg2;

        public double Mul(double arg1, double arg2) => arg1 * arg2;

        public int? Div(int arg1, int arg2)
        {
            try
            {
                return arg1 / arg2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
