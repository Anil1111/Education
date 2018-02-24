using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = {1, 2, 3, 4, 5, 6};
            Method(massive);
            Console.WriteLine();
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{massive[i] }");
            }

            //Delay
            Console.ReadKey();
        }

        private static void Method(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = 1;
                Console.Write($"{massive[i] }");
            }
        }
    }
}
