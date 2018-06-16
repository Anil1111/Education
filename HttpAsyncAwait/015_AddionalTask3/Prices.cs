using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AddionalTask3
{
    struct Price
    { 
        private string productName;
        private string shopName;
        private uint? cost;

        public string ProductName => productName;
        public string ShopName => shopName;
        public uint? Cost => cost;

        public Price(string productName, string shopName, uint? cost)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.cost = cost;
        }
    }
    class Prices
    {
        private Price[] prices ;

        public Prices()
        {
            this.prices = new Price[2];
            uint? price;
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Введите название продукта");
                var productName = Console.ReadLine();
                Console.WriteLine("Введите стоимость продукта в гривнах");
                var cost = Console.ReadLine();
                try
                {
                    price = Convert.ToUInt32(cost);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Попітка записи неверного формата.");
                    Console.WriteLine(e.Message);
                    price = null;
                }
                Console.WriteLine("Введите название магазина");
                var shopName = Console.ReadLine();

                this.prices[i] = new Price(productName, shopName, price);
                Console.Clear();
            }

            prices = prices.OrderBy(x => x.ShopName).ToArray();
        }

        public Price[] this[string shopName]
        {
            get
            {
                var array = prices.Where(x => x.ShopName == shopName).ToArray();
                if (array.Length == 0)
                {
                    try
                    {
                        throw  new Exception($"В магазине '{shopName}' нету товаров");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                return array;
            }
        }
    }
}
