using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const float g = 9.8f;
            double pi = Math.PI;
            double e = Math.E;

            Console.WriteLine(e + "\n"+pi);

            //Delay
            Console.ReadKey();
        }
    }
}
