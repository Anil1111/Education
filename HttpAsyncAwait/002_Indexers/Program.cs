using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance[0] = "string 1";  // Если я вижу такое чудо, что к экземпляру обращаются
            instance[1] = "string 2";  // так, буд-то это массив - то нужно сразу понимать, что там живет ИНДЕКСАТОР.
            instance[2] = "string 3";
            instance[3] = "string 4";
            instance[4] = "string 5";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(instance[i]);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
