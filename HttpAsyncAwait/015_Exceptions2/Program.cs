using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 0;

            try
            {
                Console.WriteLine(a / b);
            }
            catch (FormatException e)// не словит т.к исключение будет DivideByZeroException
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)// не словит т.к исключение будет DivideByZeroException
            {
                Console.WriteLine(e.Message);
            }
            //Delay
            Console.ReadKey();
        }
    }
}
