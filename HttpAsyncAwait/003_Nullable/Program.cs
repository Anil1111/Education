using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Nullable
{
    class Program
    {
        //Операция поглощения ??
        static void Main(string[] args)
        {
            int? a = null;
            int? b;
            // b = a ?? 10; все равно, что b = (a!=null) ? a : 10;
            b = a ?? 10; //b = 10
            Console.WriteLine(b);

            a = 3;
            b = a ?? 10; // b=3;
            Console.WriteLine(b);

            //Delay
            Console.ReadKey();
        }
    }
}
