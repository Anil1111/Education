using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_SelfAssociation
{
    class Program
    {//Самоассоциация (self-association)
        public void Method()
        {
            Console.WriteLine("Hello world");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Method();

            //Delay
            Console.ReadKey();
        }
    }
}
