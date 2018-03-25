using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine("Введите индекс товара");
            var index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(store[index]);

            Console.WriteLine("Введите имя товара");
            var name = Console.ReadLine();
            Console.WriteLine(store[name]);

            Console.WriteLine(new string('-', 50));
            store.Show();
            Console.WriteLine(new string('-', 50));
            store.Sort();
            store.Show();

            //Delay
            Console.ReadKey();
        }
    }
}
