using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();

            list.Add(5);
            list.Add("Hello");
            list.Add('d');
            list.Add(5.78);

            Console.WriteLine("Массив:");
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Contains(5)); //хз почему, но тут выводит false(

            //Delay
            Console.ReadKey();
        }
    }
}
