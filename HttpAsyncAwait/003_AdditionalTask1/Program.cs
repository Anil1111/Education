using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_AdditionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //up
            Printer2 printer2 = new Printer2();
            printer2.Print("Roma");
            Printer1 printer1 = printer2 as Printer1;
            printer1.Print("Roma");
            Printer printer = printer1 as Printer;
            printer.Print("Romaaaaa");
            //down
            Printer1 printer1Down = printer as Printer1;
            printer1Down.Print("Down");
            Printer2 printer2Down = printer1 as Printer2;
            printer2Down.Print("Finish");

            //Delay
            Console.ReadKey();
        }
    }
}
