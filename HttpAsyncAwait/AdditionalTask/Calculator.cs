using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    static class Calculator
    {
        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Multiple(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Devision(double value1, double value2)
        {
            if(value2==0)
            return 0 ;
            return value1 / value2;
        }

    }
}
