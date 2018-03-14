using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           var instance = new DerivedClass();
            Console.WriteLine(instance.publicField);
            instance.ShowPrivateField();

            //Delay
            Console.ReadLine();
        }
    }
}
