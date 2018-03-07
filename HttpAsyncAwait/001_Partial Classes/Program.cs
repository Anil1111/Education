using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _001_Partial_Classes.PartialClasses;

namespace _001_Partial_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();
            instance.MethodFromFirstPart();
            instance.MethodFromSecondPart();

            //Delay
            Console.ReadLine();
        }
    }
}
