using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(2);
            list.Add(1);
            list.Add(3);

            //QuickSort
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
