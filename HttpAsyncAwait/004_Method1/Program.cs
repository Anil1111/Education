using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Method1
{
    class Program
    {
        static void Operaton(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine($"{value1}, {value2},{value3}");
        }
        static void Main(string[] args)
        {
            string s = "value";
            int a = 55;
            double b = 11.2;
            Operaton();
            Operaton("val1");
            Operaton("val2",11);
            Operaton("val3",13,11.2);
            Operaton(value3:b);
            Operaton(value2:a,value3:b,value1:s);

            Operaton("Roman",(int)11.2);  //Нужно учитывать типы параметров
            

            //Delay
            Console.ReadKey();
        }
    }
}
