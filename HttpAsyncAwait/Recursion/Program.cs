using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Recursion(int i)
        {
            i--;
            Console.WriteLine($"До вызова i = {i}");
            if(i!=0)
                Recursion(i);
            Console.WriteLine($"После вызова i = {i}");
        }
        static void Main(string[] args)
        {
            Recursion(3);

            //Delay
            Console.ReadKey();
        }
    }
}
