using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_AdditionalTask1
{
    public class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class Printer1:Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class Printer2:Printer1
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
