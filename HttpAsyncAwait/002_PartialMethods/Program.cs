using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _001_Partial_Classes.PartialClasses;

namespace _002_PartialMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();
            instance.CallPartialMethod();

            //Delay
            Console.ReadKey();
        }
    }
}
