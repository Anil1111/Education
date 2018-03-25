using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my[0, 0] = 1;
            my[1, 1] = 2;

            Console.WriteLine(my[0, 0]);
            Console.WriteLine(my[1, 1]);

            Console.WriteLine(my[1, 0]); //тут выведется значение по умолчанию для типа идексатора - int => 0;

            //Delay
            Console.ReadKey();
        }
    }
}
