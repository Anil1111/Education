using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_StaticMethodsAndNotStaticFields
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance1 = new NotStaticClass(1);
            NotStaticClass instance2 = new NotStaticClass(2);

            NotStaticClass.Method();

            //Delay
            Console.ReadLine();
        }
    }
}
