using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Task2
{
    class Program
    {
        static ulong CountAmountOfOptions(ulong numberOfCustomers)
        {
            if (numberOfCustomers == 0)
                return 1;
            return numberOfCustomers * CountAmountOfOptions(numberOfCustomers - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите количество клиентов");
            ulong numberOfCustomers = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"{CountAmountOfOptions(numberOfCustomers)} вариантов доставки возможно при " +
                              $"{numberOfCustomers} клиентах");

            //Delay
            Console.ReadKey();
        }


    }
}
