using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AddionalTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prices prices = new Prices();

            Console.WriteLine("Введите название магазина, товары которого хотите посмотреть");
            var shopToShow = Console.ReadLine();

            var array = prices[shopToShow];
            if (array != null) 
            {
                foreach (var x in array)
                {
                    Console.WriteLine($"Товар '{x.ProductName}' можна купить в магазине '{x.ShopName}' по цене '{x.Cost}' грн.");
                }
            }

            //Delay
            Console.ReadKey();
        }
    }
}
