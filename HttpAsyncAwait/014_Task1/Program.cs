using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("Roma");
            list.Add("Petya");
            list.Add("Vasya");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var a = list[500];
            var secondElement = list[2];
            Console.WriteLine(secondElement);

            var arrayLength = list.Length;
            Console.WriteLine(arrayLength);


            //Delay
            Console.ReadKey();
        }
    }
}
